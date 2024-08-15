using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea_RolUsuario_SS_Heredia.Startup))]
namespace Tarea_RolUsuario_SS_Heredia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
