using System;
using BossFight.Exceptions;

namespace BossFight
{
    public class ItemStack : Item
    {
        public int Amount = 1;
        public int MaxAmount = Int32.MaxValue; // TODO: Unsure if needs to be implemented, for now leave it at int's own max.

        public void IncreaseAmount(int value = 1)
        {
            // Handle bad argument.
            if (value == 0) throw new ArgumentException($"Attempted to increase by zero amount!");
            if (value < 0)  throw new ArgumentException($"Attempted to increase by a negative amount ({value} < 0)!");

            if (Amount + value <= MaxAmount)
            {
                Amount += value;
            } else
            {
                throw new ItemStackIsFullException();
            }
        }
        public void DecreaseAmount(int value = 1)
        {
            // Handle bad argument.
            if (value == 0) throw new ArgumentException($"Attempted to decrease by zero amount!");
            if (value < 0) throw new ArgumentException($"Attempted to decrease by a negative amount ({value} < 0)!");

            if (Amount - value > 0)
            {
                Amount -= value;
            }
            else
            {
                throw new ItemStackIsEmptyException();
            }
        }
    }
}
