using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectMkt.Startup))]
namespace ProjectMkt
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
