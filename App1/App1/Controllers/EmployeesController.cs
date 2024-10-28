using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App1.Controllers
{
    public class EmployeesController: Controller
    {
        public string Display(int EmpId)
        {
            return "EmpId: " + EmpId;
        }
    }
}