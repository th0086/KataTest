using KataTest.Kata_No._1_String_average;
using NUnit.Framework;

namespace KataTest.Kata_No._2_Dead_Ants
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(0, Kata2.DeadAntCount("ant ant ant ant"));
            Assert.AreEqual(0, Kata2.DeadAntCount(null));
            Assert.AreEqual(2, Kata2.DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, Kata2.DeadAntCount("ant ant .... a nt"));
        }
    }
}