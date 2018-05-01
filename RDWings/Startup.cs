using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RDWings.Startup))]
namespace RDWings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
