using AGL.SortPet.Repository;
using AGL.SortPet.Service;
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
            container.RegisterType<IPetOwnerRepo, PetOwnerRepo>();
            container.RegisterType<IPetOwnerService, PetOwnerService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
      
    }
}