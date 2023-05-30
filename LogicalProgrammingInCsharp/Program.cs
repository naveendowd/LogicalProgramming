using LogicalProgrammingInCsharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below option");
            Console.WriteLine("1.Calculator\n2.Fibonnoci Series\n3.Prime number\n4.Coupon number\n5.Perfect number\n6.Reverse number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Welcome to Basic C# programs");
                    //Calculator.AddTwoNumbers(x,y);
                    Calculator calculator = new Calculator();
                    Console.WriteLine("Please enter 1st number");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter 2nd number");
                    int y = Convert.ToInt32(Console.ReadLine());
                    calculator.AddTwoNumberss(x, y);
                    calculator.SubstractTwoNumbers(x, y);
                    calculator.MultiplyTwoNumbers(x, y);
                    break;

                case 2:
                    Console.WriteLine("Please enter how many series you want generate");
                    int n = Convert.ToInt32(Console.ReadLine());
                    FibonoccieSeries.GennerateFibonoccieNumb(n);
                    break;
                case 3:
                    Console.WriteLine("Please enter number to check Prime or Not");
                    x = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.CheckPrimeOrNot(x);
                    break;
                case 4:
                    CouponNumber.CouponNumbers();
                    break;
                case 5:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                case 6:
                    ReverseNumber.Reverse();
                    break;
            }
        }
    }
}