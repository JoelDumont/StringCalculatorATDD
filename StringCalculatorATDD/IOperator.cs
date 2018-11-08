using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorATDD
{
    public interface IOperator
    {
        double ExecuteOperation(double[] values);

    }
}
