using System;
using System.Runtime.Serialization;

namespace BossFight.Exceptions
{
    [Serializable]
    public class ValueBelowMinValueException : Exception
    {
        // Custom message to override base Exception.
        private string message;
        
        // Use INullable and default to null, to indicate whether they get set at all.
        public int? minValue = null;
        public int? value = null;

        /// <summary>
        /// Override base Exception Message with our own custom one.
        /// </summary>
        public override string Message
        {
            get { return message; }
        }

        public ValueBelowMinValueException(int? value = null, int? minValue = null)
            : base()
        {
            SetUp(null, value, minValue);
        }

        public ValueBelowMinValueException(string message, int? value = null, int? minValue = null)
            : base(message)
        {
            SetUp(message, value, minValue);
        }

        public ValueBelowMinValueException(string message, Exception inner, int? value = null, int? minValue = null)
            : base(message, inner)
        {
            SetUp(message, value, minValue);
        }

        // Ensure Exception is Serializable
        protected ValueBelowMinValueException(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {
        }

        /// <summary>
        /// Assigns class members specific to this exception and sets default message if none is provided.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        protected private void SetUp(string message, int? value = null, int? minValue = null)
        {
            this.value = value;
            this.minValue = minValue;
            if (message == null)
            {
                this.message = $"Value is below the defined minimum! ({value} < {minValue})";
            } else
            {
                this.message = message;
            }
        }
    }
}
