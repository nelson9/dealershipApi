using System.Web;
using System.Web.Mvc;

namespace Niall_Ferguson___Syzygy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
