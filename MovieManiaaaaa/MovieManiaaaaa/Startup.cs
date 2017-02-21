using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieManiaaaaa.Startup))]
namespace MovieManiaaaaa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
