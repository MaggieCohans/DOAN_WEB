using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOAN_WEB.Startup))]
namespace DOAN_WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
