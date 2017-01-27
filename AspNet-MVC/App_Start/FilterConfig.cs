using Google.Cloud.Diagnostics.AspNet;
using System.Web;
using System.Web.Mvc;

namespace AspNet_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(ErrorReportingExceptionFilter.Create("cloud-sharp-work", "service", "version"));
            filters.Add(new HandleErrorAttribute());
        }
    }
}
