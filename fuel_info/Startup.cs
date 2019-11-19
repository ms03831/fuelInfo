using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fuel_info.Startup))]
namespace fuel_info
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
