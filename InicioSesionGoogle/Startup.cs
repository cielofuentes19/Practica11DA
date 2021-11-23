using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InicioSesionGoogle.Startup))]
namespace InicioSesionGoogle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
