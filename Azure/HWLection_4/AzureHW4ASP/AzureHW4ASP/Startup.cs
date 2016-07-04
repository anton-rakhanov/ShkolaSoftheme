using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureHW4ASP.Startup))]
namespace AzureHW4ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
