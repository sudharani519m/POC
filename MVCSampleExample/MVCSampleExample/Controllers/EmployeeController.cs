using MVCSampleExample.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCSampleExample.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> obj = new List<Employee>()
            {
               new Employee(){EmpId=101,EmpName="Sudha",Empsal=1000,EmpAddress="Hyd"},
                new Employee(){EmpId=102,EmpName="Sadhika",Empsal=2000,EmpAddress="Pune"},
                 new Employee(){EmpId=103,EmpName="Bala",Empsal=3000,EmpAddress="Mumbai"},
                 new Employee(){EmpId=104,EmpName="Sampath",Empsal=4000,EmpAddress="Chennai"},
            };
            return View(obj);
        }

        public ActionResult Practice()
        {
           
            return View();
        }
        public int M1()
        {
            return 0;
        }
    }
}