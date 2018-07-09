using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScratchWebsite.Startup))]
namespace ScratchWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
