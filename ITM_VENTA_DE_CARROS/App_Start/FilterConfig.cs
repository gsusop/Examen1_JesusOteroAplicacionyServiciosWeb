using System.Web;
using System.Web.Mvc;

namespace ITM_VENTA_DE_CARROS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
