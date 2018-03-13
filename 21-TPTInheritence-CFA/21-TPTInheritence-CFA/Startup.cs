using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_21_TPTInheritence_CFA.Startup))]
namespace _21_TPTInheritence_CFA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
