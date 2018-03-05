using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeFirst_StoredProcedures.Startup))]
namespace CodeFirst_StoredProcedures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
