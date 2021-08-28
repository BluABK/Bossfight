using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                value = newValue; 
            } 
            else if (newValue >= maxValue) 
            {
                value = maxValue;
            } 
            else if (newValue < 0) 
            { 
                value = maxValue; 
            }
            else
            {
                throw new Exception($"Unhandled new value: " + newValue);
            }
        }

        private void SetMaxValueIfValid(int newMaxValue)
        {
            if (newMaxValue >= 0)
            {
                maxValue = newMaxValue;
            }
        }


    }
}
