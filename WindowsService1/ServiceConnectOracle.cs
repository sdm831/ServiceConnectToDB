using System.IO;
using System.ServiceProcess;
using System.Threading;

namespace WindowsService1
{
    public partial class ServiceConnectOracle : ServiceBase
    {
        Inserter inserter;

        public ServiceConnectOracle()
        {
            InitializeComponent();
            this.CanStop = true;
            this.AutoLog = true;
        }

        protected override void OnStart(string[] args)
        {
            if (!Directory.Exists(@"c:\test"))
            {
                Directory.CreateDirectory(@"c:\test");
            }

            Print.PrintToLog("Service started");

            inserter = new Inserter();
            Thread loggerThread = new Thread(new ThreadStart(inserter.Start));
            loggerThread.Start();
        }

        protected override void OnStop()
        {
            Print.PrintToLog("Service stoped");
            inserter.Stop();
            Thread.Sleep(1500);
        }
    }
}
