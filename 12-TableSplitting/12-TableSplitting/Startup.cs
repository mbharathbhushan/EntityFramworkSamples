using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_12_TableSplitting.Startup))]
namespace _12_TableSplitting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
