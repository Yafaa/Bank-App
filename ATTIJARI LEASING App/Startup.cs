using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATTIJARI_LEASING_App.Startup))]
namespace ATTIJARI_LEASING_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
