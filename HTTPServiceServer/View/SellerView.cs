using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTPServiceServer.View
{
    public class SellerView : IView
    {
        public string Render()
        {
            var client = new HTTPServiceServer.ServiceReference1.UtilServiceClient();
            client.Open();
            var result = client.GetSellers();
            client.Close();
            return result;
        }
    }
}