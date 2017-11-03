<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <NuGetReference>rda.SocketsForPCL</NuGetReference>
  <Namespace>Sockets.Plugin</Namespace>
  <Namespace>Sockets.Plugin.Abstractions</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
</Query>

// demonstrates a basic object transmission protocol, using json serialization

const int tcpPort = 50000;

async Task Main()
{
	await DoListener();
	await DoClient();
}

public Task DoListener()
{
	var listener = new TcpSocketListener();
	
	listener.ConnectionReceived += async (sender, args) => 
	{
		"".Dump("Client connected");
		var client = args.SocketClient;
		
		// we're expecting a myfirstobject, then a mysecondobject
		await client.ReceiveObject<MyFirstObject>().Dump("MyFirstObject");
		await client.ReceiveObject<MySecondObject>().Dump("MySecondObject");
			
		"".Dump("Client disconnected");
		
		await listener.StopListeningAsync();
	};
	
	return listener.StartListeningAsync(tcpPort);	
}

public async Task DoClient()
{
	var client = new TcpSocketClient();
	await client.ConnectAsync("localhost", tcpPort);

	await Task.Delay(1000);

	// first we send a MyFirstObject
	var myFirst = MyFirstObject.GetSampleObject();
	await client.SendObject(myFirst);
	
	// then we wait a bit
	await Task.Delay(1000);
	
	// then we send a MySecondObject
	var mySecond = MySecondObject.GetSampleObject(myFirst);
	await client.SendObject(mySecond);
	
	await client.DisconnectAsync();
}

// Implements a basic object reading/writing protocol
// it's just like the string writing one, 
// with a json serialization step first
// bytes 1 - sizeof(int32) 	: message length
// subsequent bytes			: message
// to handle objects that serialize to
// longer than int32.maxvalue we'd need to chunk 
//
// for a version that doesn't require you to know the type upfront,
// see https://github.com/rdavisau/sockethelpers-for-pcl/blob/master/SocketHelpers/SocketHelpers/Messaging/JsonProtocolMessenger.cs
public static class StringHelpers
{
	public static async Task<T> ReceiveObject<T>(this ITcpSocketClient c)
	{
		// get the length of the next message
		var sizeOfInt = sizeof(Int32);
		var sizeBuf = new byte[sizeOfInt];
		
		await c.ReadStream
			   .ReadAsync(sizeBuf, 0, sizeOfInt)
			   .ConfigureAwait(false);
		
		// convert to int
		var msgLength = BitConverter.ToInt32(sizeBuf, 0);
		
		// get the actual message
		var msgBuf = new byte[msgLength];
		await c.ReadStream
			   .ReadAsync(msgBuf, 0, msgLength)
			   .ConfigureAwait(false);

		// convert to obj
		var json = Encoding.UTF8.GetString(msgBuf, 0, msgLength);
		var obj = JsonConvert.DeserializeObject<T>(json);
		
		return obj;
	}
	
	public static Task SendObject<T>(this ITcpSocketClient c, T obj)
	{
		var json = JsonConvert.SerializeObject(obj);
		
		// convert to utf8 bytes
		var msgBytes = Encoding.UTF8.GetBytes(json);
		var msgLength = msgBytes.Length;
		var msgLengthBytes = BitConverter.GetBytes(msgLength);
		
		// prepare the bytes to send
		var allBytes = Enumerable.Concat(msgLengthBytes, msgBytes).ToArray();
		
		// send 
		return c.WriteStream.WriteAsync(allBytes, 0, allBytes.Length);				
	}
}

public class MyFirstObject
{
	public string Name { get; set; }
	public int FavNumber { get; set; }
	public DateTime DOB { get; set; }
	
	public static MyFirstObject GetSampleObject()
	{
		return new MyFirstObject
		{
			Name = "Barry",
			FavNumber = 21,
			DOB = DateTime.Now.AddYears(-30)
		};
	}
}

public class MySecondObject
{
	public string SubjectName { get; set; }
	public List<string> Students { get; set; }
	public List<DateTime> Classes { get; set; }
	public MyFirstObject MyFirstObject { get; set; }
	
	public MySecondObject()
	{
		Students = new List<string>();
		Classes = new List<DateTime>();
	}
	
	public static MySecondObject GetSampleObject(MyFirstObject myFirstObject)
	{
		return new MySecondObject
		{
			SubjectName = "Biology",
			Students = 
			{
				"Alice",
				"Bob",
				"Delta force"
			},
			Classes = 
			{
				DateTime.Now.AddDays(5),
				DateTime.Now.AddDays(7)
			},
			MyFirstObject = myFirstObject
		};
	}
}
