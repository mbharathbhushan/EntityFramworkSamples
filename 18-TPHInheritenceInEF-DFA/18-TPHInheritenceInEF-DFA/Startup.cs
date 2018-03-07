using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_18_TPHInheritenceInEF_DFA.Startup))]
namespace _18_TPHInheritenceInEF_DFA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
