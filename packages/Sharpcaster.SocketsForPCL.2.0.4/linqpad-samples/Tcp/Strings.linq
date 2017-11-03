<Query Kind="Program">
  <NuGetReference>rda.SocketsForPCL</NuGetReference>
  <Namespace>Sockets.Plugin</Namespace>
  <Namespace>Sockets.Plugin.Abstractions</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// demonstrates a basic string transmission protocol

const int tcpPort = 50000;
const string eof = "<eof>";

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
		
		var msg = "";
		while (msg != eof)
		{
			msg = await args.SocketClient.ReceiveString().Dump();
		} 
		
		"".Dump("Client disconnected");
		
		await listener.StopListeningAsync();
	};
	
	return listener.StartListeningAsync(tcpPort);	
}

public async Task DoClient()
{
	var client = new TcpSocketClient();
	await client.ConnectAsync("localhost", tcpPort);
	
	foreach (var s in "Look how easily I can send strings!".Split(' '))
	{ 	
		await client.SendString(s);
		await Task.Delay(250);
	}
	
	await client.SendString(eof);
	await client.DisconnectAsync();
}

// Implements a basic string reading/writing protocol
// bytes 1 - sizeof(int32) 	: message length
// subsequent bytes			: message
// to handle messages longer than int32.maxvalue
// we'd need to chunk 
public static class StringHelpers
{
	public static async Task<string> ReceiveString(this ITcpSocketClient c)
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

		// convert to string
		var msg = Encoding.UTF8.GetString(msgBuf, 0, msgLength);
		
		return msg;
	}
	
	public static Task SendString(this ITcpSocketClient c, string s)
	{
		// convert to utf8 bytes
		var msgBytes = Encoding.UTF8.GetBytes(s);
		var msgLength = msgBytes.Length;
		var msgLengthBytes = BitConverter.GetBytes(msgLength);
		
		// prepare the bytes to send
		var allBytes = Enumerable.Concat(msgLengthBytes, msgBytes).ToArray();
		
		// send 
		return c.WriteStream.WriteAsync(allBytes, 0, allBytes.Length);				
	}
}
