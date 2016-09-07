using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Niall_Ferguson___Syzygy.Startup))]
namespace Niall_Ferguson___Syzygy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
