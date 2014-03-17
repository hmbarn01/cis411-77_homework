using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework6.Startup))]
namespace Homework6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
