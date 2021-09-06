using System;
using System.Runtime.Serialization;

namespace MysticHorizonsLib.Exceptions
{
    [Serializable]
    public class ItemStackIsFullException : Exception
    {
        public ItemStackIsFullException()
        {
        }

        public ItemStackIsFullException(string message)
            : base(message)
        {
        }

        public ItemStackIsFullException(string message, Exception inner)
            : base(message, inner)
        {
        }

        // Ensure Exception is Serializable
        protected ItemStackIsFullException(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        { 
        }
    }
}
