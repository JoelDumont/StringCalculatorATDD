using System;
using System.Linq;

namespace StringCalculatorATDD
{
    public class StringCalculator : IStringCalculator
    {
        private IOperator addOperator;
        private IConverter converter;

        public StringCalculator(IOperator addOperator, IConverter converter)
        {
            this.addOperator = addOperator;
            this.converter = converter;
        }

        public double Calculate(String input)
        {
            string[] splittedString = input.Split(',');
            if (input == "")
            {
                return 0;
            }
            else
            {
                return splittedString.Select(s => Convert.ToDouble(s)).Sum();
            }
        }
    }
}