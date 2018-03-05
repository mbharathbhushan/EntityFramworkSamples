using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_10.Startup))]
namespace _10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
