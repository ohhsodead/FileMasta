<Query Kind="Program">
  <NuGetReference>rda.SocketsForPCL</NuGetReference>
  <Namespace>Sockets.Plugin</Namespace>
  <Namespace>Sockets.Plugin.Abstractions</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// basic TcpSocketClient
// first start listening with the TcpSocketListener query, then connect with this one

const int tcpPort = 50000;
	
async Task Main()
{
	var client = new TcpSocketClient();
	await client.ConnectAsync("localhost", tcpPort);
	
	for (var i = 0; i < 5; i++)
	{
		await client.WriteStream.WriteAsync(new [] { (byte) i }, 0, 1);
		await client.WriteStream.FlushAsync();
	}
	
	await client.DisconnectAsync();
}

// Define other methods and classes here