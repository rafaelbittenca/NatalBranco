using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NatalBranco.Startup))]
namespace NatalBranco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
