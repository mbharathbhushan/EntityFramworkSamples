using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_22_ManyToManyRelationShip.Startup))]
namespace _22_ManyToManyRelationShip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
