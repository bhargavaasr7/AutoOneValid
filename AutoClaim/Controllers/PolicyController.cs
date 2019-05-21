using AutoClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoClaim.ViewModel;
using System.Data.Entity;

namespace AutoClaim.Controllers
{
    public class PolicyController : Controller
    {
        private ApplicationDbContext dbContext = null;
        public PolicyController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // GET: Policy
        public ActionResult Index()
        {
            List<Policy> policies = dbContext.Policies.Include(m => m.insurancePolicy).ToList();
            return View(policies);
            


        }
        [HttpGet]
        public ActionResult Registration()
        {
            PolicyInsuranceViewModel viewModel = new PolicyInsuranceViewModel();
            Policy policy = new Policy();
            var insurancePolicies = dbContext.InsurancePolicies.ToList();
            viewModel.Policy = policy;
            viewModel.InsurancePolicies = insurancePolicies;
            return View(viewModel);
         
      
        }
        [HttpPost]
        public ActionResult Registration(Policy policy)
        {
            if (ModelState.IsValid)
            {
                dbContext.Policies.Add(policy);
                dbContext.SaveChanges();  //store in database
                return RedirectToAction("Index", "Policy");
            }
            else
            {
                PolicyInsuranceViewModel viewModel = new PolicyInsuranceViewModel();
                Policy policy1 = new Policy();
                var insurancePolicies = dbContext.InsurancePolicies.ToList();
                viewModel.Policy = policy1;
                viewModel.InsurancePolicies = insurancePolicies;
                return View(viewModel);
            }


        }
        public ActionResult CustomerDetails()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateLogin(Policy policy)
        {
            return View();
        }

        public ActionResult CustomerLogin()
        {
            return View();
        }
        public ActionResult UserLogin()
        {
            return View();
        }
        public ActionResult ReportWithoutRegistration()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Registration_For_Insurance()
        {
            return View();
        }

        public ActionResult Faq()
        {
            return View();
        }

        public ActionResult Last()
        {
            return View();
        }
    
    }
}