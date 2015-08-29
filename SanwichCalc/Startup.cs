using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SanwichCalc.Startup))]
namespace SanwichCalc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
