using System.Web;
using System.Web.Mvc;

namespace _13_TableSplitting_CodeFirstApproach
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
