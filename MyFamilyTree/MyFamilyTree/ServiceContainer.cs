using System.Linq;
using System.Reflection;
using Autofac;
using MyFamilyTree.BusinessLogic.Family.Models;
using MyFamilyTree.Presentation.Views;
using MyFamilyTree.ViewModels;

namespace MyFamilyTree.IOC
{
    public sealed class ServiceContainer
    {
        static ServiceContainer()
        {
            var containerBuilder = new ContainerBuilder();

            var presentationLayer = Assembly.GetAssembly(typeof(MyFamilyViewModel));
            var businessLayer = Assembly.GetAssembly(typeof(PersonModel));
            
            containerBuilder.RegisterAssemblyTypes(businessLayer).Where(t => t.Name.EndsWith("Service")).As(t => t.GetInterface($"I{t.Name}"));
            containerBuilder.RegisterAssemblyTypes(presentationLayer).Where(t => t.Name.EndsWith("Page")).AsSelf();
            containerBuilder.RegisterAssemblyTypes(presentationLayer).Where(t => t.Name.EndsWith("ViewModel")).AsSelf();

            containerBuilder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();

            Instance = containerBuilder.Build();
        }

        public static IContainer Instance;        
    }
}
