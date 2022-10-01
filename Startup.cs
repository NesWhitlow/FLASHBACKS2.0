using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FLASHBACKS.Startup))]
namespace FLASHBACKS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
