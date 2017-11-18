using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Changes.Startup))]
namespace Changes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
