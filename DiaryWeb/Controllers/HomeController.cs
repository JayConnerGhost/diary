using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiaryWeb.Services;

namespace DiaryWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfigurationService _configuration;

        public HomeController(IConfigurationService configuration)
        {
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            ViewData["ApplicationName"] = _configuration.ApplicationName;
            return View();
        }
        
    }
}