using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Summer_school_mvc.Startup))]
namespace Summer_school_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
