using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KataTest.Kata_No._3_Band_name_generator
{
    class SampleTest
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void SampleTest()
            {
                Assert.AreEqual("The Knife", Kata3.BandNameGenerator("knife"));
                Assert.AreEqual("Tartart", Kata3.BandNameGenerator("tart"));
                Assert.AreEqual("Sandlesandles", Kata3.BandNameGenerator("sandles"));
                Assert.AreEqual("The Bed", Kata3.BandNameGenerator("bed"));
            }
        }
    }
}
