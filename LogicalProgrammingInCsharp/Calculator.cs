using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    class Calculator
    {
        public void AddTwoNumberss(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum:{0}", sum);
        }
        public void SubstractTwoNumbers(int x, int y)
        {
            int diff = Math.Abs(x - y);
            Console.WriteLine("Difference:{0}", diff);
        }

        public void MultiplyTwoNumbers(int x, int y)
        {
            int product = x * y;
            Console.WriteLine("Product of 2numbers:{0}", product);
        }
    }
}
