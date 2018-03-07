using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorPage.Startup))]
namespace RazorPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
