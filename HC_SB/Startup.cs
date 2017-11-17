using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HC_SB.Startup))]
namespace HC_SB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
