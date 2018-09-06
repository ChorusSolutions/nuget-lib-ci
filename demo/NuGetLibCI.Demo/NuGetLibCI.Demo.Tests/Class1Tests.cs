using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetLibCI.Demo.Tests
{
    [TestFixture]
    public class Class1Tests
    {
        [Test]
        public void Result_IsAdditionOfParams()
        {
            int a = 2;
            int b = 3;
            Class1 c = new Class1();

            int actual = c.Add(a, b);

            int expected = a + b;

            Assert.AreEqual(expected, actual);
        }
    }
}