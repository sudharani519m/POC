using MVCDemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> obj = new List<Employee>()
            {
                new Employee(){EmpId=101,EmpName="dasharad",EmpSal=1000,EmpAddress="Hyd"},
                 new Employee(){EmpId=102,EmpName="sudha",EmpSal=2000,EmpAddress="Chennai"},
                  new Employee(){EmpId=103,EmpName="sadhika",EmpSal=3000,EmpAddress="Pune"},
                   new Employee(){EmpId=104,EmpName="Bala",EmpSal=4000,EmpAddress="Mumbai"},
            };
            return View(obj);
        }

        public ActionResult Parctice()
        {

            return View();
        }
        public int M1()
        {
            return 0;
        }
    }
}