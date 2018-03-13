using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_23_ManyToManyRelationShip_CFA.Startup))]
namespace _23_ManyToManyRelationShip_CFA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
