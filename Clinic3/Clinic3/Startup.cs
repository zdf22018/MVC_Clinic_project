using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clinic3.Startup))]
namespace Clinic3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
