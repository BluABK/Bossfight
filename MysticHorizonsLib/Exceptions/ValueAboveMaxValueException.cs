using System;
using System.Runtime.Serialization;

namespace MysticHorizonsLib.Exceptions
{
    [Serializable]
    public class ValueAboveMaxValueException : Exception
    {
        // Custom message to override base Exception.
        private string message;

        // Use INullable and default to null, to indicate whether they get set at all.
        public int? maxValue = null;
        public int? value = null;

        /// <summary>
        /// Override base Exception Message with our own custom one.
        /// </summary>
        public override string Message
        {
            get { return message; }
        }

        public ValueAboveMaxValueException(int? value = null, int? maxValue = null)
            : base()
        {
            SetUp(null, value, maxValue);
        }

        public ValueAboveMaxValueException(string message, int? value = null, int? maxValue = null)
            : base(message)
        {
            SetUp(message, value, maxValue);
        }

        public ValueAboveMaxValueException(string message, Exception inner, int? value = null, int? maxValue = null)
            : base(message, inner)
        {
            SetUp(message, value, maxValue);
        }

        // Ensure Exception is Serializable
        protected ValueAboveMaxValueException(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {
        }

        /// <summary>
        /// Assigns class members specific to this exception and sets default message if none is provided.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="value"></param>
        /// <param name="maxValue"></param>
        protected private void SetUp(string message, int? value = null, int? maxValue = null)
        {
            this.value = value;
            this.maxValue = maxValue;
            if (message == null)
            {
                this.message = $"Value exceeds the defined maximum! ({value} > {maxValue})";
            }
            else
            {
                this.message = message;
            }
        }
    }
}
