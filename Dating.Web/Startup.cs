using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dating.Web.Startup))]
namespace Dating.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
