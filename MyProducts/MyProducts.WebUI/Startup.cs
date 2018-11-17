using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProducts.WebUI.Startup))]
namespace MyProducts.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
