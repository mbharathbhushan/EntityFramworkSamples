using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_19_TPHInheritenceInEF_CFA.Startup))]
namespace _19_TPHInheritenceInEF_CFA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
