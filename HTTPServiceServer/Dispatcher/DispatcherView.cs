using HTTPServiceServer.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTPServiceServer.Dispatcher
{
    public class DispatcherView
    {
        public string Route(string routePath)
        {
            IView view = chooseView(routePath);
            if(view != null)
            {
                return view.Render();
            }
            return "";
        }

        private IView chooseView(string name)
        {
            IView view = null;
            switch(name)
            {
                case "clients":
                    view = new ClientView();
                    break;
                case "sellers":
                    view = new SellerView();
                    break;
            }
            return view;
        }
    }
}