using System;
using BossFight.Exceptions;

namespace BossFight
{
    public class ConsumableAttribute
    {
        private int value;
        public int Value 
        { 
            get => value;
            set => SetValueIfValid(value);
        }
        private const int MinValue = 0;
        private int maxValue;
        public int MaxValue
        {
            get => maxValue;
            set => SetMaxValueIfValid(value);
        }


        public ConsumableAttribute(int value)
        {
            this.value = maxValue = value;
        }

        private void SetValueIfValid(int newValue) 
        {
            if (newValue >= 0 && newValue <= maxValue) 
            {
                // If new value is between 0 and max, assign it to own value.
                value = newValue; 
            } 
            else if (newValue > maxValue) 
            {
                throw new ValueAboveMaxValueException(newValue, maxValue);
            } 
            else if (newValue < 0) 
            {
                throw new ValueBelowMinValueException(newValue, MinValue);
            }
            else
            {
                throw new Exception($"Unhandled new value: " + newValue);
            }
        }

        private void SetMaxValueIfValid(int newMaxValue)
        {
            if (newMaxValue >= MinValue)
            {
                maxValue = newMaxValue;
            } else
            {
                throw new ValueBelowMinValueException(newMaxValue, MinValue);
            }
        }


    }
}
