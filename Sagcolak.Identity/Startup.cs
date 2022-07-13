using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sagcolak.Identity.Startup))]
namespace Sagcolak.Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
