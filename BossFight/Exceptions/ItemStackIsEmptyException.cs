using System;
using System.Runtime.Serialization;

namespace BossFight.Exceptions
{
    [Serializable]
    public class ItemStackIsEmptyException : Exception
    {
        private ItemStack itemStack = null;
        public ItemStackIsEmptyException()
        {
        }

        public ItemStackIsEmptyException(ItemStack itemStack = null)
        {
            this.itemStack = itemStack;
        }

        public ItemStackIsEmptyException(string message, ItemStack itemStack = null)
            : base(message)
        {
            this.itemStack = itemStack;
        }

        public ItemStackIsEmptyException(string message, Exception inner, ItemStack itemStack = null)
            : base(message, inner)
        {
            this.itemStack = itemStack;
        }

        // Ensure Exception is Serializable
        protected ItemStackIsEmptyException(SerializationInfo info, StreamingContext ctxt, ItemStack itemStack = null)
            : base(info, ctxt)
        {
            this.itemStack = itemStack;
        }
    }
}
