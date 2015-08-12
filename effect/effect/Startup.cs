using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(effect.Startup))]
namespace effect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
