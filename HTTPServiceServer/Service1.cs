using HTTPServiceServer.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace HTTPServiceServer
{
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        private FrontController frontController;
        public Service1()
        {
            frontController = new FrontController();
        }
        public System.IO.Stream Get(string path)
        {
            string output = frontController.ProcessRoute(path);
            byte[] outputBytes = Encoding.UTF8.GetBytes(output);
            WebOperationContext.Current.OutgoingResponse.ContentType = "text/html";
            return new MemoryStream(outputBytes);
        }
    }

    
}
