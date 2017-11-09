<Query Kind="Program">
  <NuGetReference>rda.SocketsForPCL</NuGetReference>
  <Namespace>Sockets.Plugin</Namespace>
  <Namespace>Sockets.Plugin.Abstractions</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// demonstrates sending and receiving udp datagrams 

const int udpPort = 30000;
const string eof = "<eof>";

async Task Main()
{
	await DoReceiver();
	await DoClient();
}

public Task DoReceiver()
{
	var receiver = new UdpSocketReceiver();
	
	receiver.MessageReceived += async (sender, args) => 
	{
		var msg = Encoding.UTF8.GetString(args.ByteData);
		
		if (msg != eof)
			Console.Write(msg + " ");
		else
			await receiver.StopListeningAsync();
	};
	
	return receiver.StartListeningAsync(udpPort);
}

public async Task DoClient()
{
	var client = new UdpSocketClient();
	
	// you can send messages without 'connecting'
	// udp is connectionless and stateless, so calling connect
	// just specifies a default destination
	foreach (var msg in "no guarantee these will even be delivered!".Split(' '))
	{
		var bs = Encoding.UTF8.GetBytes(msg);
		await client.SendToAsync(bs, "localhost", udpPort);
		await Task.Delay(250);
	}
	
	await Task.Delay(1000);
	
	// if we connect, any calls to SendAsync will send data to the 
	// specified remote address
	await client.ConnectAsync("localhost", udpPort);
	
	foreach (var msg in "look ma, no target!".Split(' '))
	{
		var bs = Encoding.UTF8.GetBytes(msg);
		await client.SendAsync(bs);
		await Task.Delay(500);
	}
	
	var eofBytes = Encoding.UTF8.GetBytes(eof);
	await client.SendAsync(eofBytes);
}

// Define other methods and classes here
