using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESBTest.Startup))]
namespace ESBTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
