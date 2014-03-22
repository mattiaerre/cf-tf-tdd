using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CFTFTDD.CF.WEB.Startup))]
namespace CFTFTDD.CF.WEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
