using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AyseSagcolak.Startup))]
namespace AyseSagcolak
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
