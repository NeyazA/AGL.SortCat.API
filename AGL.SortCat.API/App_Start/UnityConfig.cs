using AGL.SortCat.API.Controllers;
using AGL.SortCat.Repository;
using AGL.SortCat.Service;
using System.Web.Http;
using Unity;
using Unity.Injection;
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

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            container.RegisterType<IOwnerService, OwnerService>();
            container.RegisterType<IOwnerRepo, OwnerRepo>();
            
        }
    }
}