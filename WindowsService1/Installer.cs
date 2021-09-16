using System.ComponentModel;
using System.ServiceProcess;

namespace WindowsService1
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        ServiceInstaller serviceInstaller;
        ServiceProcessInstaller processInstaller;

        public Installer()
        {
            InitializeComponent();
            serviceInstaller = new ServiceInstaller();
            processInstaller = new ServiceProcessInstaller();

            processInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller.StartType = ServiceStartMode.Manual;
            serviceInstaller.ServiceName = "DbConnect";
            serviceInstaller.Description = "Service to connect to DB";
            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
    }
}
