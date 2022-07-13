using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestSilinecek.Startup))]
namespace TestSilinecek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
