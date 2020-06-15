using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite_CUENTAS.Startup))]
namespace WebSite_CUENTAS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
