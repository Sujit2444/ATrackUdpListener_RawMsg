using System;
using System.Threading;

namespace ATrackUdpNetBase
{
    public class ListenerRunner
    {
        UdpServer udpserver = null;
        Thread listenerThread = null;
        int port = 4000;
        private void CreateAll()
        {
            Utils.LogMessage("Calling CreateAll()");
            udpserver = new UdpServer(port);
            
            listenerThread = new Thread(udpserver.Run);
           
            listenerThread.IsBackground = true;

        }

        public ListenerRunner(int _port)
        {
            Utils.LogMessage("Calling ListenerRunner");
            port = _port;
            CreateAll();
        }

        public void Start()
        {
            Utils.LogMessage("Calling Start()");
            listenerThread.Start();
        }

        public void Stop()
        {
            Utils.LogMessage("Calling Stop()");
            listenerThread.Abort();
            Thread.Sleep(100);
        }
    }
}
