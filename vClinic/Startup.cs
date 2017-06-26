using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vClinic.Startup))]
namespace vClinic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
