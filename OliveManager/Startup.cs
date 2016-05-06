using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OliveManager.Startup))]
namespace OliveManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
