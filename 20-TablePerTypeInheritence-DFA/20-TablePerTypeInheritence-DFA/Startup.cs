using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20_TablePerTypeInheritence_DFA.Startup))]
namespace _20_TablePerTypeInheritence_DFA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
