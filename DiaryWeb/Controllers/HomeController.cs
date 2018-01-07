using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiaryWeb.Services;

namespace DiaryWeb.Controllers
{
    public class HomeController : BaseController
    {

        public HomeController(IConfigurationService configuration):base(configuration)
        {
        }

        public ActionResult Index()
        {
            ViewData["ApplicationName"] = Configuration.ApplicationName;
            return View();
        }
        
    }
}