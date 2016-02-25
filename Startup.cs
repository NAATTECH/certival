using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CERTIVAL.Startup))]
namespace CERTIVAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
