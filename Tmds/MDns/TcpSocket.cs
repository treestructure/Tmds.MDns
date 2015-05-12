using System.Net.Sockets;
using System.Net;
using System.NetworkInformation;

namespace Tmds.MDns
{
	
	private Socket _socket;
	
	internal class TcpSocket
	{
		public TcpSocket()
		{
			_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastInterface, IPAddress.HostToNetworkOrder(_index));
            _socket.Bind(new IPEndPoint(IPAddress.Any, IPv4EndPoint.Port));
            IPAddress ip = IPv4EndPoint.Address;
            _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip, _index));
            _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 1);
		}	
		
		
		public void SendTo()
		{
			
		}
		
		public void Dispose()
		{
			
		}
		
		public void BeginReceive()
		{
			
		}
		
		public int EndReceive(IAsyncResult res)
		{
			
		}
	}
}