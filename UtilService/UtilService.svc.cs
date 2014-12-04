using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UtilService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UtilService : IUtilService
    {

        public string GetClients()
        {
            return "<html><head><title>Klienci</title></head><body>" +
                "<h1>Inwestorzy</h1><a href=\"sellers\">Skocz do sprzedawcow</a>" +
                 "</body></html>";
        }

        public string GetSellers()
        {
            return "<html><head><title>Sprzedawcy</title></head><body>" +
                "<h1>Sprzedawcy</h1><a href=\"clients\">Skocz do klientow</a>" +
                "</body></html>";
        }
    }
}
