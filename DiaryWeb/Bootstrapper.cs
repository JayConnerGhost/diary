using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using DiaryWeb.Controllers;
using DiaryWeb.Services;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
namespace DiaryWeb
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IAuthenticationManager>(
                new InjectionFactory(
                    o => System.Web.HttpContext.Current.GetOwinContext().Authentication
                )
            );
            container.RegisterType<IUserStore<Diary.Models.ApplicationUser>, UserStore<Diary.Models.ApplicationUser>>();
            container.RegisterType<UserManager<Diary.Models.ApplicationUser>>();
            container.RegisterType<DbContext, Diary.Models.ApplicationDbContext>();
            container.RegisterType<ApplicationUserManager>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<IConfigurationService, ConfigurationService>();
            return container;
        }
    }
}