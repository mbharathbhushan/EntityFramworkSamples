using System.Web;
using System.Web.Mvc;

namespace _20_TablePerTypeInheritence_DFA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
