using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using ATrackUdpNetBase;

namespace ATrackUdpListener_RawMsg
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Utils.LogMessage("Calling Main()");
            ServiceBase[] ServicesToRun;
         
            ServicesToRun = new ServiceBase[]
            {
            new ATrackUdpListener_RawMsg()
            };
            
            ServiceBase.Run(ServicesToRun);
          
        }
    }
}
