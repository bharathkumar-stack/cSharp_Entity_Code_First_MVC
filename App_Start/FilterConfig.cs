using System.Web;
using System.Web.Mvc;

namespace EF_Code_First_MVC_Employe_Crud
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
