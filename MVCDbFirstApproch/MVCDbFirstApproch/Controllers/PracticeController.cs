using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDbFirstApproch.Models;
namespace MVCDbFirstApproch.Controllers
{
    public class PracticeController : Controller
    {
        sampleDBEntities1 db = new sampleDBEntities1();

        // GET: Practice
        public ActionResult Index()
        {
            var empList = db.Employees.ToList();
            return View(empList);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}