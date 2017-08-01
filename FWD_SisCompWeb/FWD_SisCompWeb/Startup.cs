using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FWD_SisCompWeb.Startup))]
namespace FWD_SisCompWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
