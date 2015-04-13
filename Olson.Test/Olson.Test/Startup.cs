using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Olson.Test.Startup))]
namespace Olson.Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
