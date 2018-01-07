using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiaryWeb.Services;

namespace DiaryWeb.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IConfigurationService Configuration;

        protected BaseController(IConfigurationService configuration)
        {
            Configuration = configuration;
        }
    }
}