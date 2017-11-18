using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bazy.Startup))]
namespace Bazy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
