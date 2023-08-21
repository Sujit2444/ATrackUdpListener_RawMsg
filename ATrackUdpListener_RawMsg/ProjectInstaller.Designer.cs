namespace ATrackUdpListener_RawMsg
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TytUdpNetInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.TytUdpNetserviceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // TytUdpNetInstaller
            // 
            this.TytUdpNetInstaller.Account = System.ServiceProcess.ServiceAccount.NetworkService;
            this.TytUdpNetInstaller.Password = null;
            this.TytUdpNetInstaller.Username = null;
            this.TytUdpNetInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.TytUdpNetInstaller_AfterInstall);
            // 
            // TytUdpNetserviceInstaller
            // 
            this.TytUdpNetserviceInstaller.Description = "TYT .NET Udp Multi Port Listener";
            this.TytUdpNetserviceInstaller.DisplayName = "TYT .NET Udp Multi Port Listener V2";
            this.TytUdpNetserviceInstaller.ServiceName = "ATrackUdpListener_RawMsg_RawMsg";
            this.TytUdpNetserviceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.TytUdpNetInstaller,
            this.TytUdpNetserviceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller TytUdpNetInstaller;
        private System.ServiceProcess.ServiceInstaller TytUdpNetserviceInstaller;
    }
}