using System.Web;
using System.Web.Mvc;

namespace _21_TPTInheritence_CFA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
