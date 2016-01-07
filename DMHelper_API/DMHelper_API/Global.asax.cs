using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


using Castle.Windsor;
using Castle.Windsor.Installer;
using DMHelper_API.Plumbing;


namespace DMHelper_API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private static WindsorContainer _container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfigureIOC();

        }

        internal void ConfigureIOC()
        {
            _container = new WindsorContainer();
            _container.AddFacility<WindsorFacility>();
            
            _container.Install(new WindsorInstaller());
            GlobalConfiguration.Configuration.DependencyResolver = new WindsorDependencyResolver(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_container));

        }
    }
}
