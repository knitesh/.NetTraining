using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
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
            GlobalConfiguration.Configure(WebApiConfig.Register);
            InitRavenStore();
        }

        private static void InitRavenStore()
        {
            Store = new EmbeddableDocumentStore {ConnectionStringName = "RavenDB"};
            Store.Conventions.IdentityPartsSeparator = "-";
            Store.Initialize();
        }
    }
}
