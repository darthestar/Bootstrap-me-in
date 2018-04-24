using System.Web;
using System.Web.Mvc;

namespace Bootstrap_me_in
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
