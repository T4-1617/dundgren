using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demo0927.Startup))]
namespace demo0927
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
