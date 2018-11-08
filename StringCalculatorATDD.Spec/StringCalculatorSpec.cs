using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbehave;
using Xunit;

namespace StringCalculatorATDD
{
    public class StringCalculatorSpec
    {
        private IStringCalculator stringCalculator;

        [Background]
        public void Background()
        {
            $"Given a Calculator to calculate the sum of two numbers".x(() =>
                stringCalculator = new StringCalculator(new AddOperator()));
        }

        [Scenario]
        public void CalculateTheSumOfAnArbitraryLongString()
        {
            double result = 0;

            $"When the sum of empty string is calculated".x(() => result = stringCalculator.Calculate(""));
            
            $"Then the sum should be zero".x(() => Assert.Equal(0,result));

            $"When the sum of one is calculated".x(() => result = stringCalculator.Calculate("1"));

            $"Then the sum should be one".x(() => Assert.Equal(1,result));

            $"When the sum of one and two is calculated".x(() => result = stringCalculator.Calculate("1,2"));

            $"Then the sum should be three".x(() => Assert.Equal(3.0,result));
        }

   }
}
