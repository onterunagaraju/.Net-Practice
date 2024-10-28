using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.SessionState;

namespace App1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            /*System.Web.Routing.RouteTable.Routes.MapRoute("route1", "home", new { controller = "Controller1", action = "Action1" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route2", "about", new { controller = "Controller1", action = "Action2" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route3", "contact", new { controller = "Controller1", action = "Action3" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route4", "products", new { controller = "Controller2", action = "Action4" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route5", "services", new { controller = "Controller2", action = "Action5" });
*/
            // Generic URL Routing
            //System.Web.Routing.RouteTable.Routes.MapRoute("route1", "{controller}/{action}");

            /*// Route Parameters
            System.Web.Routing.RouteTable.Routes.MapRoute("route1", "{controller}/{action}/{category}");*/

            /*// Optional Parameters
            System.Web.Routing.RouteTable.Routes.MapRoute("route1", "{controller}/{action}/{category}", new {category = UrlParameter.Optional});
*/

            /*// Default Parameters
            System.Web.Routing.RouteTable.Routes.MapRoute("route1", "{controller}/{action}/{category}", new { category = "Electronics" });
*/
            // Constraints on  Parameters
            System.Web.Routing.RouteTable.Routes.MapRoute("route1", "{controller}/{action}/{category}", new { }, new {category = @"^[a-zA-Z]*$"});
            System.Web.Routing.RouteTable.Routes.MapRoute("route2", "{controller}/{action}/{empid}", new { }, new { empid = @"^[0-9]*$" });



        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}