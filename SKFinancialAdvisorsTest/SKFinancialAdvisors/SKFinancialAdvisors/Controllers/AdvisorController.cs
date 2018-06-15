using SKFinancialAdvisors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKFinancialAdvisors.Controllers
{
    public class AdvisorController : Controller
    {
        // GET: Advisor
        /// <summary>
        /// Gets the profile for the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Profiles()
        {
            AdvisorContext advisorContext = new AdvisorContext();
            Advisor advisor = advisorContext.Advisors.Single(adv => adv.Id == 1);
            
            return View(advisor);
        }       
    }
}