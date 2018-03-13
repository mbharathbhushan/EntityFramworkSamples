using System.Web;
using System.Web.Mvc;

namespace _23_ManyToManyRelationShip_CFA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
