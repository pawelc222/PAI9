using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace HTTPServiceServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(Service1), new Uri[] { new Uri("http://localhost:8080") });

            ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(IService1), new WebHttpBinding(), "web");
            endpoint.Behaviors.Add(new WebHttpBehavior());

            ServiceDebugBehavior sdb = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            sdb.HttpHelpPageEnabled = false;

            //var b = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            //if (b == null) b = new ServiceMetadataBehavior();
            //host.Description.Behaviors.Add(b);

            //host.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            host.Open();

            Console.WriteLine("Server is running ...");
            Console.ReadLine();

            host.Close();
        }
    }
}
