using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuxuryCarRental.Startup))]
namespace LuxuryCarRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
