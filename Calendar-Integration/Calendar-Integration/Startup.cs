using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calendar_Integration.Startup))]
namespace Calendar_Integration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
