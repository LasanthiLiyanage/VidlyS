using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyS.Startup))]
namespace VidlyS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
