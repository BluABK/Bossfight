using NUnit.Framework;

namespace TestBossFight
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        
        [Test]
        public void TestThatFails()
        {
            Assert.Fail();
        }
    }
}