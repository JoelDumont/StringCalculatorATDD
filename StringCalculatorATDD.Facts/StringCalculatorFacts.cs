using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace StringCalculatorATDD.Facts
{
    public class StringCalculatorFacts
    {
        private IStringCalculator testee;
        private IOperator addOperator;
        private IConverter converter;

        public StringCalculatorFacts()
        {
            addOperator = new AddOperator();
            converter = new Converter();
            testee = new StringCalculator(addOperator, converter);
        }

        [Theory]
        [InlineData("1,2",3)]
        [InlineData("1",1)]
        [InlineData("",0)]
        public void CalculateReturnsThree_WhenOneAndTwo(string input,double expected)
        {
            var result = testee.Calculate(input);
            result.Should().Be(expected);
        }


    }
}
  