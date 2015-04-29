using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Raven.Client;
using Raven.Client.Embedded;

namespace UserManagementSystem
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static IDocumentStore Store { get; private set; }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            CreateRavenDbDocumentStore();
        }


        private static void CreateRavenDbDocumentStore()
        {
            Store = new EmbeddableDocumentStore { ConnectionStringName = "RavenDB" };
            Store.Conventions.IdentityPartsSeparator = "-";
            Store.Initialize();
           
        }
    }
}
