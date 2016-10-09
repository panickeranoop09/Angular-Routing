using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularRouting.Startup))]
namespace AngularRouting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
