using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lektion0927.Startup))]
namespace lektion0927
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
