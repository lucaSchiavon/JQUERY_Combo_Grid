using System.Web;
using System.Web.Mvc;

namespace Griglie_Combo_Auto_Completamento
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
