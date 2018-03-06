using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_15_ConditionalFiltering_CFA.Startup))]
namespace _15_ConditionalFiltering_CFA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
