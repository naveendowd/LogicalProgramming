using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    class FibonoccieSeries
    {
        public static void GennerateFibonoccieNumb(int n)
        {
            int numb1 = 0, numb2 = 1, sum;
            for (int i = 0; i <= n; i++)
            {

                sum = numb1 + numb2;
                Console.WriteLine("{0}", sum);
                numb1 = numb2;
                numb2 = sum;
            }
            /* int numb1 = 0, numb2 = 1, sum = 0;
             Console.WriteLine("Printing fibonooci series:");
             if (n == 1)
             {
                 Console.WriteLine("{0}", numb1);
             }
             else if (n == 2)
             {
                 Console.WriteLine("{0} {1}", numb1, numb2);
             }
             else
             {
                 Console.Write("{0} {1}", numb1, numb2);
                 for (int i = 3; i <= n; i++)
                 {
                     sum = numb1 + numb2;
                     Console.WriteLine("{0}", sum);
                     numb1 = numb2;
                     numb2 = sum;
                 }
             }*/
        }

    }
}
