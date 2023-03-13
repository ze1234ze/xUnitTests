using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTutorialYouTube
{
    public class Calculator
    {
       // private CalculatorState _state = CalculatorState.Cleared;

        public decimal Value { get; set; } = 0;

        public decimal Add(decimal value, decimal value2)
        {
            Value = 0;
           // _state = CalculatorState.Active;
            return Value = value + value2;
        }

        public decimal Substract(decimal value, decimal value2)
        {
            //_state = CalculatorState.Active;
            return Value = value - value2;  
        }

        public decimal Divide(decimal value, decimal value2)
        {
            //_state = CalculatorState.Active;
            return Value = value / value2;
        }

        public decimal Multiplizieren(decimal value, decimal value2)
        {
           // _state = CalculatorState.Active;
            return Value = value * value2;
        }
    }
}
