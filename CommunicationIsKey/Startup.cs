using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunicationIsKey.Startup))]
namespace CommunicationIsKey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
