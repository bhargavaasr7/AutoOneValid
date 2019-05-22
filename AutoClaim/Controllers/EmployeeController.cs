using AutoClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoClaim.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext = null;
        public EmployeeController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Register   register)
        {
            var user = dbContext..SingleOrDefault(c => c.UserName == registeredUser.UserName && c.Password == registeredUser.Password);
            if (user!=null)
            {
                if (user.UserName.StartsWith("AS"))
                {
                    return RedirectToAction("Index", "Assessor");
                }
               else if (user.UserName.StartsWith("CO"))
                {
                    return RedirectToAction("Index", "ClaimOfficer");
                }
            }
            else
            {
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }
    }
}