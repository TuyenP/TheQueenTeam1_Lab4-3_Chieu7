using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab4_3.Startup))]
namespace Lab4_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
