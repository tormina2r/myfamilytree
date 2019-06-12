using System.Linq;
using System.Reflection;
using Autofac;
using MyFamilyTree.BusinessLogic.Family.Models;
using MyFamilyTree.Data.UserProfile;
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
            var dataLayer = Assembly.GetAssembly(typeof(UserProfileDal));
            var serviceLayer = Assembly.GetAssembly(typeof(IUserProfileDal));

            containerBuilder.RegisterAssemblyTypes(businessLayer, dataLayer, serviceLayer).Where(t => t.Name.EndsWith("Service")).As(t => t.GetInterface($"I{t.Name}"));
            containerBuilder.RegisterAssemblyTypes(dataLayer, serviceLayer).Where(t => t.Name.EndsWith("Dal")).As(t => t.GetInterface($"I{t.Name}"));
            containerBuilder.RegisterAssemblyTypes(presentationLayer).Where(t => t.Name.EndsWith("Page")).AsSelf();
            containerBuilder.RegisterAssemblyTypes(presentationLayer).Where(t => t.Name.EndsWith("ViewModel")).AsSelf();

            Instance = containerBuilder.Build();
        }

        public static IContainer Instance;        
    }
}
