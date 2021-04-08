using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FissalReportes.Startup))]
namespace FissalReportes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
