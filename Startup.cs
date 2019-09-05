using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(luce_MIS4200.Startup))]
namespace luce_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
