using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App1.Controllers
{
    public class ProductsController: Controller
    {
        public string Show(string category)
        {
            return "Category: " + category;
        }
    }
}