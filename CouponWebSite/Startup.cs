using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CouponWebSite.Startup))]
namespace CouponWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
