using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlanetClient.Startup))]
namespace PlanetClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
