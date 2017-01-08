using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

namespace CaClient.WindowServices
{
    partial class CaClientWindowServices : ServiceBase
    {
        public ServiceHost serviceHost = null;
        List<ServiceHost> serviceHosts = new List<ServiceHost>();

        public CaClientWindowServices()
        {
            InitializeComponent();
            ServiceName = "CAClientWindowService";
        }

        protected override void OnStart(string[] args)
        {
            serviceHost = new ServiceHost(typeof(CAClient.Service.Client.ClientDetails));
            serviceHosts.Add(serviceHost);
            serviceHost = new ServiceHost(typeof(CAClient.Service.CAUtils.CountryDetails));
            serviceHosts.Add(serviceHost);
            serviceHost = new ServiceHost(typeof(CAClient.Service.Audit.AuditDetails));
            serviceHosts.Add(serviceHost);

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            foreach (var service in serviceHosts)
            {
                service.Open();
            }
        }

        protected override void OnStop()
        {
            foreach (var serviceHost in serviceHosts)
            {
                if (serviceHost != null)
                {
                    serviceHost.Close();
                }
            }
        }
    }
}
