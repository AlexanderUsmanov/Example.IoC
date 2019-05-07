using SimpleInjector;

namespace Example.IoC.Shell
{
    public class Package : SimpleInjector.Packaging.IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IUserLoader, CsvUserLoader>();
            container.Register<ITimeService, SystemTimeService>();
            container.Register<IUserPrinter, ConsoleUserPrinter>();
            container.Register<ICsvParser, CsvParser>();
            container.Register<CommandProcessor>();
        }
    }
}
