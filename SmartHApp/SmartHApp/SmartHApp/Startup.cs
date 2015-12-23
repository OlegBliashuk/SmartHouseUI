using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartHApp.Startup))]
namespace SmartHApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
