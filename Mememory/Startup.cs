using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mememory.Startup))]
namespace Mememory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
