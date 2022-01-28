using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICalculator
    {
        public int Sum(int first, int second);
        public int Substract(int first, int second);
        public int Multiply(int first, int second);


    }
}
