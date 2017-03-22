using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iasset_technical_test.Startup))]
namespace iasset_technical_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
