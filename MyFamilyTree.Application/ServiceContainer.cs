using DryIoc;

namespace MyFamilyTree.Application
{
    public static class ServiceContainer
    {
        public static IContainer Instance;

        static ServiceContainer()
        {
            Instance = new Container();
        }
    }
}
