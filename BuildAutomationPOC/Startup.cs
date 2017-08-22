using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildAutomationPOC.Startup))]
namespace BuildAutomationPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
