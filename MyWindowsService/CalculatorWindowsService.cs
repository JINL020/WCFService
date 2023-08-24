using MyService;
using System;
using System.ServiceModel;
using System.ServiceProcess;

namespace MyWindowsService
{
    public partial class CalculatorWindowsService : ServiceBase
    {
        private ServiceHost serviceHost = null;

        public CalculatorWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            StartService();
        }

        protected override void OnStop()
        {
            StopService();
        }

        private void StartService()
        {
            try
            {
                if (serviceHost == null)
                {
                    serviceHost = new ServiceHost(typeof(CalculatorService));
                }

                serviceHost.Open();
                // Log service started
            }
            catch (Exception)
            {
                // Log error and handle exceptions
            }
        }

        private void StopService()
        {
            try
            {
                if (serviceHost != null)
                {
                    serviceHost.Close();
                    serviceHost = null;
                    // Log service stopped
                }
            }
            catch (Exception)
            {
                // Log error and handle exceptions
            }
        }
    }
}
