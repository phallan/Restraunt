using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restraunt.Startup))]
namespace Restraunt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
