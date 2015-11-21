using Autofac;
using Autofac.Integration.Mvc;
using BlingBackend.Autofac;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BlingBackend.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterControllers(typeof(MvcApplication).Assembly);
            containerBuilder.RegisterModule(new BlingBackendAutofacModule());
            DependencyResolver.SetResolver(new AutofacDependencyResolver(containerBuilder.Build()));
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}