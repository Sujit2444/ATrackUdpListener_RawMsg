using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Configuration;

namespace ATrackUdpNetBase
{
    public class UdpServer
    {
        // TODO - evaluate change to http://msdn.microsoft.com/en-us/library/system.net.sockets.udpclient.beginreceive.aspx
        private int _port = 0;

        public UdpServer(int port)
        {
            Utils.LogMessage("Calling UdpServer()");
            _port = port;
        }
        public void Run()
        {
            Utils.LogMessage("Calling Run() ");
            string ipString = ConfigurationManager.AppSettings["ATrackIPAddress"];
            Utils.LogMessage("Server IP: "+ipString);
            IPEndPoint localEP = new IPEndPoint(IPAddress.Parse(ipString), this._port);
            Utils.LogMessage("Port Number: " + _port);
            UdpClient client = new UdpClient();
            client.ExclusiveAddressUse = false;
            client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            client.Client.Bind(localEP);
            client.DontFragment = true;
            while (true)
            {
                try
                {
                    Utils.LogMessage("Service Running");
                    IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
                    byte[] what = client.Receive(ref remote);
                    Utils.LogData(System.BitConverter.ToString(what));
                }
                catch (System.Exception ex)
                {
                    Utils.LogMessage("Exception Run(): "+ex.Message);
                }
                finally
                { }
            }
        }
    }
}
