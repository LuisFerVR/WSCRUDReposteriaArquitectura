using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSCRUDReposteriaArquitectura.Startup))]
namespace WSCRUDReposteriaArquitectura
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
