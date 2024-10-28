using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public void Index()
        {
            /*Response.Write("<p>URL: " + Request.Url.ToString() + "</p>");
            Response.Write("<p>Path: " + Request.Path + "</p>");
            Response.Write("<p>Query String: " + Request.QueryString + "</p>");
            Response.Write("<p>Method: " + Request.HttpMethod + "</p>");
            Response.Write("<p>Request headers: " + Request.Headers["User-Agent"] + "</p>");
            Response.Write("<p>Browser: " + Request.Browser.Type + "</p>");
            Response.Write("<p>Physical App Path: " + Request.PhysicalApplicationPath + "</p>");*/

            Response.Write("Hello World");
            Response.Headers.Add("X", "100");
            Response.ContentType = "text/plain";
            Response.StatusCode = 500;

        }
    }
}