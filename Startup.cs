using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WicconTest.Startup))]
namespace WicconTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
