using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asd.Startup))]
namespace asd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
