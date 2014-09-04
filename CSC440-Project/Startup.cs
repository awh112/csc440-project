using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSC440_Project.Startup))]
namespace CSC440_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
