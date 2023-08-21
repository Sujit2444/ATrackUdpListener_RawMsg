using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using ATrackUdpNetBase;

namespace ATrackUdpListener_RawMsg
{
    public partial class ATrackUdpListener_RawMsg : ServiceBase
    {
        public ATrackUdpListener_RawMsg()
        {
            InitializeComponent();
            
        }

        ListenerRunner target;

        protected override void OnStart(string[] args)
        {
            Utils.LogMessage("Service Start");
            int _port=Convert.ToInt32(ConfigurationManager.AppSettings["port"]);
            Utils.LogMessage("Port Number: "+_port);
            target = new ListenerRunner(_port);
           
            target.Start();
          
        }

        protected override void OnStop()
        {
            Utils.LogMessage("Service Stop");
            if (target != null)
           
            target.Stop();
           
        }
    }
}
