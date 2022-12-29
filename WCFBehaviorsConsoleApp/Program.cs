using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using WCFBehaviorsConsoleApp.Services.Concrete;
using System.Runtime.Serialization;
using System.Web.Services.Description;

namespace WCFBehaviorsConsoleApp
{
    class Program
    {
        private static ServiceHost dataService;
        static void Main(string[] args)
        {
            try
            {
                dataService = new ServiceHost(typeof(DataService));
                dataService.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to start DataService:" + e.ToString());
            }

            Console.WriteLine("Service started at http://localhost:1234/DataService");
            Console.ReadLine();
        }
    }

}
