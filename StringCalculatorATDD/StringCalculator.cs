using System;
using System.Linq;

namespace StringCalculatorATDD
{
    public class StringCalculator : IStringCalculator
    {
        private IOperator addOperator;

        public StringCalculator(IOperator addOperator)
        {
            this.addOperator = addOperator;
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