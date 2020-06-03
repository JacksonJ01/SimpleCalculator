using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     class CalculatorOperations
    {
        public static double Adding(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtracting(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Divison(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Exponent(double num1, double num2)
        {
            double num3 = 1;
            for (int num = 0; num < num2; num++)
            {
                num3 *= num1;
            }
            return num3;
        }

        public static double Root(double num1, double num2)
        {
            for (int num = 1; num < num2; num++)
            {
                num1 /= num2;
            }
            return num1;
        }
    }
}
