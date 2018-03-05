using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_11_EntitySplitting_CodeFirstApproach.Startup))]
namespace _11_EntitySplitting_CodeFirstApproach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
