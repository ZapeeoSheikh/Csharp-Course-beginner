using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public double Sum(double a, double b )
        {
            double add = a + b;
            return add;
        }
        public double Sub(double a, double b )
        {
            double sub = a - b;
            return sub;
        }
        public double Mul(double a, double b )
        {
            double mul = a * b;
            return mul;
        }
        public double Div(double a, double b )
        {
            double div = a / b;
            return div;
        }
    }
}
