using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MathWizard.Startup))]
namespace MathWizard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
