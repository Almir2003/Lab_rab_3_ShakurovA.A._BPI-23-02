using System.Web;
using System.Web.Mvc;

namespace Lab_rab_3._Shakurov_Almir_БПИ_23_02
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
