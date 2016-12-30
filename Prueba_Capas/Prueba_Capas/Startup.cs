using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba_Capas.Startup))]
namespace Prueba_Capas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
