using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ML_TP034533.Startup))]
namespace ML_TP034533
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
