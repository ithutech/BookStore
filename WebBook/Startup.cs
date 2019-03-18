using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBook.Startup))]
namespace WebBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
