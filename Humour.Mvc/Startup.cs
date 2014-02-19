using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Humour.Mvc.Startup))]
namespace Humour.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
