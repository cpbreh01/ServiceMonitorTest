using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;

namespace ServiceMonitorTest
{
    public class ServiceControllerHelper
    {
        private ServiceController monitoredService;

        public ServiceControllerHelper()
        {
            string ServiceName = "dhcp";
            monitoredService = new ServiceController(ServiceName, Environment.MachineName);
        }

        public string GetCurrentStatus()
        {
            ServiceControllerStatus _status = monitoredService.Status;

            return _status.ToString();
            
        }

        public string GetServiceName()
        {
            return monitoredService.DisplayName;
        }
      
    }
}
