using System.Web;
using System.Web.Mvc;

namespace _15_ConditionalFiltering_CFA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
