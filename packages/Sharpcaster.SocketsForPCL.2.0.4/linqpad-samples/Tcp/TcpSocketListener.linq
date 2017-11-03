<Query Kind="Program">
  <NuGetReference>rda.SocketsForPCL</NuGetReference>
  <Namespace>Sockets.Plugin</Namespace>
  <Namespace>Sockets.Plugin.Abstractions</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// basic TcpSocketListener
// start listening with this query, then open the TcpSocketClient query and have it connect

const int tcpPort = 50000;

async Task Main()
{
	var listener = new TcpSocketListener();
	
	listener.ConnectionReceived += async (sender, args) => 
	{
		"Client connected :)".Dump();
		
		int bytesRead = -1;
		byte[] buf = new byte[1];
		
		while (bytesRead != 0)
		{
			bytesRead = await args.SocketClient.ReadStream.ReadAsync(buf, 0, 1);
			buf.Dump();
		}
	
		"Client disconnected :(".Dump();
		
		await listener.StopListeningAsync();
	};
	
	await listener.StartListeningAsync(tcpPort);
}

// Define other methods and classes here