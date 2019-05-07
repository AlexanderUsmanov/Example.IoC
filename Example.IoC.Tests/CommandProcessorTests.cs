using System;
using Example.IoC.Shell;
using NUnit.Framework;
using SimpleInjector;

namespace Example.IoC.Tests
{
    public class CommandProcessorTests
    {
        private TestTimeService timeService;
        private TestUserLoader userLoader;
        private TestUserPrinter userPrinter;
        private CommandProcessor commandProcessor;

        [SetUp]
        public void Setup()
        {
            SimpleInjector.Container container = new SimpleInjector.Container();
            ConfigureContainer(container);

            commandProcessor = new CommandProcessor(userLoader, timeService, userPrinter);
        }

        private void ConfigureContainer(SimpleInjector.Container container)
        {
            timeService = new TestTimeService();
            userLoader = new TestUserLoader();
            userPrinter = new TestUserPrinter();

            container.RegisterSingleton<IUserLoader>(() => userLoader);

            container.RegisterSingleton(typeof(ITimeService), () => timeService);

            container.Register<IUserPrinter>(() => userPrinter, SimpleInjector.Lifestyle.Singleton);

            container.Register<CommandProcessor>();

            container.Verify();
        }

        [Test]
        public void PrintUsersWithBirthdayToday_Empty()
        {
            timeService.Now = new DateTime(2019,01,01);

            commandProcessor.PrintUsersWithBirthdayToday();

            Assert.AreEqual(0, userPrinter.Output.Count);
        }

        [Test]
        public void PrintUsersWithBirthdayToday_One_One()
        {
            DateTime now = new DateTime(2019, 01, 01);
            User testUser = new User { Name = "Test", Email = "test@test.com", Birthday = now };

            timeService.Now = now;
            userLoader.Users.Add(testUser);

            commandProcessor.PrintUsersWithBirthdayToday();

            Assert.AreEqual(1, userPrinter.Output.Count);
            Assert.AreEqual(testUser.Email, userPrinter.Output[0].Email);
        }

        [Test]
        public void PrintUsersWithBirthdayToday_Two_One()
        {
            DateTime now1 = new DateTime(2019, 01, 01);
            DateTime now2 = new DateTime(2018, 01, 02);
            User testUser1 = new User { Name = "Test1", Email = "test@test.com", Birthday = now1 };
            User testUser2 = new User { Name = "Test2", Email = "test@test.com", Birthday = now2 };

            timeService.Now = now1;
            userLoader.Users.Add(testUser1);
            userLoader.Users.Add(testUser2);

            commandProcessor.PrintUsersWithBirthdayToday();

            Assert.AreEqual(1, userPrinter.Output.Count);
            Assert.AreEqual(testUser1.Email, userPrinter.Output[0].Email);
        }
    }
}
