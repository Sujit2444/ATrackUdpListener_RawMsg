using System;
using System.Windows.Forms;
using ATrackUdpNetBase;

namespace ATrackUdpListenerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Utils.LogMessage("Calling Form1()");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utils.LogMessage("Calling Form1_Load()");
            StartLMUMessageProcessor();
        }

        private static void StartLMUMessageProcessor()
        {
            Utils.LogMessage("Calling StartLMUMessageProcessor()");
            ListenerRunner target;
            int _port = 2052;
            target = new ListenerRunner(_port);
            target.Start();
        }
    }
}
