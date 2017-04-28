using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(blogPeter.Startup))]
namespace blogPeter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
