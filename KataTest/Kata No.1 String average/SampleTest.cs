using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KataTest.Kata_No._1_String_average
{

    [TestFixture]
    public class Test
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("four", Kata1.AverageString("zero nine five two"));
            Assert.AreEqual("three", Kata1.AverageString("four six two three"));
            Assert.AreEqual("three", Kata1.AverageString("one two three four five"));
            Assert.AreEqual("four", Kata1.AverageString("five four"));
            Assert.AreEqual("zero", Kata1.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", Kata1.AverageString("one one eight one"));
            Assert.AreEqual("n/a", Kata1.AverageString(""));
            Assert.AreEqual("n/a", Kata1.AverageString("$$#@!!~!"));
        }
    }
}

