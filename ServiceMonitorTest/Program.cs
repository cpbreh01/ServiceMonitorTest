using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceMonitorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ServiceControllerHelper> ListOfServices = new List<ServiceControllerHelper>();

            //Create ServiceToMonitor Objects
            ServiceControllerHelper ServiceToMonitor = new ServiceControllerHelper();

            //Add ServiceToMonitorObjects to list.
            ListOfServices.Add(ServiceToMonitor);
            string _response = string.Empty;

            while (!_response.Equals("n"))
            {
                Console.WriteLine("");

                Console.WriteLine("Would you like to check status of service? 'Y' or 'N'");
                _response = Console.ReadKey().KeyChar.ToString().ToLower();
                Console.WriteLine("");
                switch (_response)
                {
                    case "n":
                        Console.Write("Exiting Program.");
                        break;
                    case "y":
                        Console.Write(string.Format("Checking Services..."));
                        foreach (ServiceControllerHelper serviceToCheck in ListOfServices)
                        {
                            Console.WriteLine(string.Format("Name: {0} Status: {1}", serviceToCheck.GetServiceName(), serviceToCheck.GetCurrentStatus()));
                        }
                        break;
                    default:
                        Console.Write(string.Format("Unknown response: {0}. No action taken. Use 'N' to exit", _response));
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
