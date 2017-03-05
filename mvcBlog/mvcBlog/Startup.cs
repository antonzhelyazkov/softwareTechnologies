using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcBlog.Startup))]
namespace mvcBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
