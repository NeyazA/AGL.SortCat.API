
using AGL.Sortcat.Utility;
using AGL.SortCat.Repository;
using AGL.SortCat.Service;
using System;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace AGL.SortCat.API
{
    public static class UnityConfig
    {

        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IOwnerService, OwnerService>();
            container.RegisterType<IOwnerRepo, OwnerRepo>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
      
    }
}