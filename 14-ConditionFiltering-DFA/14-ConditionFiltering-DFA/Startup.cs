using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_14_ConditionFiltering_DFA.Startup))]
namespace _14_ConditionFiltering_DFA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
