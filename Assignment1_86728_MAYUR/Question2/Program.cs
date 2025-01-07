using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Mul(int a, int b)
        {
            return a * b;
        }

        static int Div(int a, int b)
        {
            return (a / b);
        }


        static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);

            switch (args[2])
            {

                case "+":
                    Console.WriteLine(Add(a, b));
                    break;
                case "-":
                    Console.WriteLine(Sub(a, b));
                    break;
                case "*":
                    Console.WriteLine(Mul(a, b));
                    break;
                case "/":
                    Console.WriteLine(Div(a, b));
                    break;
            }

        }
    }
}
