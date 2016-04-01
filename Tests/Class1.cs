using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {
            Console.WriteLine("Command line args:");
            Environment.GetCommandLineArgs()
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine("Environment variables:");
            Environment.GetEnvironmentVariables()
                .Cast<DictionaryEntry>()
                .ToList()
                .ForEach(x => Console.WriteLine("{0}={1}", x.Key, x.Value));

            Assert.Pass();
        }
    }
}
