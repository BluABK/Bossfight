using NUnit.Framework;
using BossFight.Exceptions;

namespace BossFight.Tests
{
    public class ItemStackTest
    {
        public const int BaseMaxAmount = 20;
        public const string BaseItemName = "Health Potion";
        public const int BaseItemId = 1;
        public const int BaseItemValue = 20;

        [SetUp]
        public void Setup()
        {
        }

        private protected ItemStack CreateBaseItemStack() 
        {
            return new() 
            { 
                Id = BaseItemId, Name = BaseItemName, Value = BaseItemValue,
                Amount = 1, MaxAmount = BaseMaxAmount
            };
        }

        [Test]
        public void TestMaxValueNotExceeded()
        {
            Assert.Throws<ItemStackIsFullException>(() => CreateBaseItemStack().IncreaseAmount(BaseMaxAmount + 1));
        }

        [Test]
        public void TestAmountDoesNotGoToZero()
        {
            Assert.Throws<ItemStackIsEmptyException>(() => CreateBaseItemStack().DecreaseAmount(BaseMaxAmount));
        }

        [Test]
        public void TestAmountDoesNotGoBelowZero()
        {
            Assert.Throws<ItemStackIsEmptyException>(() => CreateBaseItemStack().DecreaseAmount(BaseMaxAmount + 1));
        }
    }
}
