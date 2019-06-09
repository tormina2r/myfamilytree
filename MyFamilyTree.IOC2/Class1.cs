using System;
using System.Linq;
using System.Reflection;
using Autofac;
using MyFamilyTree.BusinessLogic.Family.Models;
using MyFamilyTree.Data.UserProfile;

namespace MyFamilyTree.IOC2
{
    public sealed class ServiceContainer
    {
        private static IContainer _instance;

        public static IContainer GetInstance(Action<ContainerBuilder> configure = null) 
            => _instance ?? (_instance = Configure(configure));

        private static IContainer Configure(Action<ContainerBuilder> configure = null)
        {
            var containerBuilder = new ContainerBuilder();
            configure?.Invoke(containerBuilder);

            var businessLogicAssembly = Assembly.GetAssembly(typeof(PersonModel));
            var dataAssembly = Assembly.GetAssembly(typeof(UserProfileEntity));
            containerBuilder.RegisterAssemblyTypes(businessLogicAssembly, dataAssembly)
                .Where(t => t.Name.EndsWith("Service"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == $"I{t.Name}"));

            containerBuilder.RegisterAssemblyTypes(businessLogicAssembly, dataAssembly)
                .Where(t => t.Name.EndsWith("Dal"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == $"I{t.Name}"));

            return containerBuilder.Build();
        }
    }
}
