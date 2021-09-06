using NUnit.Framework;
using MysticHorizonsLib.Exceptions;

namespace MysticHorizonsLib.Tests
{
    public class ConsumableAttributeTest
    {
        const int BaseMaxValue = 50;

        [SetUp]
        public void Setup()
        {
        }

        private protected static ConsumableAttribute CreateBaseConsumableAttribute()
        {
            return new ConsumableAttribute(BaseMaxValue);
        }

        [Test]
        public void TestMaxValueIsSetCorrectly()
        {

            ConsumableAttribute myConsumableAttribute = new(BaseMaxValue);

            Assert.AreEqual(BaseMaxValue, myConsumableAttribute.MaxValue);
        }

        [Test]
        public void TestSetNegativeMaxValueFails()
        {
            Assert.Throws<ValueBelowMinValueException>(() => CreateBaseConsumableAttribute().MaxValue = -1);
        }

        [Test]
        public void TestSetZeroMaxValue()
        {
            const int NewMaxValue = 0;
            ConsumableAttribute myConsumableAttribute = new(BaseMaxValue);

            myConsumableAttribute.MaxValue = NewMaxValue;

            Assert.AreEqual(NewMaxValue, myConsumableAttribute.MaxValue);
        }

        [Test]
        public void TestSetPositiveMaxValue()
        {
            const int NewMaxValue = 1;
            ConsumableAttribute myConsumableAttribute = new(BaseMaxValue);

            myConsumableAttribute.MaxValue = NewMaxValue;

            Assert.AreEqual(NewMaxValue, myConsumableAttribute.MaxValue);
        }

        [Test]
        public void TestValueIsSetCorrectly()
        {
            ConsumableAttribute myConsumableAttribute = new(BaseMaxValue);

            Assert.AreEqual(BaseMaxValue, myConsumableAttribute.Value);
        }

        [Test]
        public void TestSetSameAsBaseMaxValue()
        {
            ConsumableAttribute myConsumableAttribute = new(BaseMaxValue);

            myConsumableAttribute.Value = BaseMaxValue;

            Assert.AreEqual(BaseMaxValue, myConsumableAttribute.Value);
        }

        [Test]
        public void TestSetOneAboveMaxValueFails()
        {
            Assert.Throws<ValueAboveMaxValueException>(() => CreateBaseConsumableAttribute().Value = BaseMaxValue + 1);
        }

        [Test]
        public void TestSetOneBelowMaxValue()
        {
            ConsumableAttribute myConsumableAttribute = new(BaseMaxValue);

            myConsumableAttribute.Value = BaseMaxValue - 1;

            Assert.AreEqual(BaseMaxValue - 1, myConsumableAttribute.Value);
        }

        [Test]
        public void TestSetZeroValue()
        {
            ConsumableAttribute myConsumableAttribute = new(BaseMaxValue);

            myConsumableAttribute.Value = 0;

            Assert.AreEqual(0, myConsumableAttribute.Value);
        }

        [Test]
        public void TestSetNegativeValueFails()
        {
            Assert.Throws<ValueBelowMinValueException>(() => CreateBaseConsumableAttribute().Value = -1);
        }
    }
}
