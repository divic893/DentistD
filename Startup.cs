using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DentistD.Startup))]
namespace DentistD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
