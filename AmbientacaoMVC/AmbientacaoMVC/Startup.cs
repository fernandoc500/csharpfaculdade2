using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmbientacaoMVC.Startup))]
namespace AmbientacaoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
