using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebShop.WebUI.Startup))]
namespace MyWebShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
