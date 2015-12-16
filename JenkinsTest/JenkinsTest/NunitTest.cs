using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JenkinsTest
{
    
    public class NunitTest
    {
        [Test]
        public void TestAssert()
        {
            var a = 5;
            Assert.AreEqual(5, a);
        }
    }
}
