using HTTPServiceServer.Dispatcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTPServiceServer.Controller
{
    public class FrontController
    {
        private DispatcherView dispatcher;
        public FrontController()
        {
            dispatcher = new DispatcherView();
        }
        public string ProcessRoute(string routePath)
        {
            return dispatcher.Route(routePath);
        }
    }
}