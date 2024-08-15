using System.Web;
using System.Web.Mvc;

namespace Tarea_RolUsuario_SS_Heredia
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
