using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_16_SelfReferingAssociation.Startup))]
namespace _16_SelfReferingAssociation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
