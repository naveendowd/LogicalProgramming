using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    class PrimeNumber
    {
        public static void CheckPrimeOrNot(int number) //5
        {
            int m = number / 2;
            int flag = 0;
            for (int i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Not a prime number");
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine("{0} is a prime number", number);

            }
        }
    }
}
