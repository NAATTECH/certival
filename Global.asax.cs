using CERTIVAL.DAL;
using CERTIVAL.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CERTIVAL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            MappingConfig.MappingRegistration();

            var certivalDb = new CertivalContext();
            var procedimientos = certivalDb.Procedimientos.ToList();
            var applicationDb = new ApplicationDbContext();
            var usuarioAdmin = applicationDb.Users.Select(u => u.Email == "pablo.vilchis@gmail.com").ToList();

        }

    }
}
