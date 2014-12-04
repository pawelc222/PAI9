using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTPServiceServer.View
{
    public class ClientView : IView
    {
        public string Render()
        {
            var client = new HTTPServiceServer.ServiceReference1.UtilServiceClient();
            client.Open();
            var result = client.GetClients();
            client.Close();
            return result;
        }
    }
}