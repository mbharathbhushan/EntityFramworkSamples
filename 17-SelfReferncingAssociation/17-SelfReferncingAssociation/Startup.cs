using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_17_SelfReferncingAssociation.Startup))]
namespace _17_SelfReferncingAssociation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
