using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebApplication1.Startup))]
namespace DemoWebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
