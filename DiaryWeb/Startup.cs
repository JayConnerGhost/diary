using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiaryWeb.Startup))]
namespace DiaryWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
