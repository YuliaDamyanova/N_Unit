using NUnit.Framework;

namespace Project1_NUnit
{
    public class TestsAssert
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AssertationExample()
        {
            Assert.That(9 == 9);
        }
    }
}