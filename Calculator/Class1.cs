using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double value1, double value2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "A":
                    result = value1 + value2;
                    break;
                case "S":
                    result = value1 - value2;
                    break;
                case "M":
                    result = value1 * value2;
                    break;
                case "D":
                    if (value2 != 0)
                    {
                        result = value1 / value2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
