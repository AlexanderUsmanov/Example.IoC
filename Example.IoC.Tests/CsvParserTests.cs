using System;
using System.Collections.Generic;
using System.IO;
using Example.IoC.Shell;
using NUnit.Framework;

namespace Tests
{
    public class CsvParserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ParseZeroUsers()
        {
            CsvParser parser = new CsvParser();
            String input = "";

            List<User> users = parser.ParseUsers(new StringReader(input));
            Assert.AreEqual(users.Count, 0);
        }

        [Test]
        public void ParseOneUser()
        {
            CsvParser parser = new CsvParser();
            String input = "name;email@host.com;1993.03.24";

            List<User> users = parser.ParseUsers(new StringReader(input));
            Assert.AreEqual(users.Count, 1);
        }
    }
}