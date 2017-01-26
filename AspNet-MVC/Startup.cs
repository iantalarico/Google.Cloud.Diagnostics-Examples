using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNet_MVC.Startup))]
namespace AspNet_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
