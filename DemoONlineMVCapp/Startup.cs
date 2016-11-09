using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoONlineMVCapp.Startup))]
namespace DemoONlineMVCapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
