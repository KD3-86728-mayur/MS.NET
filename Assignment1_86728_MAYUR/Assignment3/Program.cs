using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3

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

        static int Menu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUBSTRACT");
            Console.WriteLine("3. MULTIPLICATION");
            Console.WriteLine("4. DIVISION");

            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        static void Main(string[] args)
        {
            int num;

            while ((num = Menu()) != 0)
            {
                Console.WriteLine("Enter the two number");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Addition is : " + Add(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Substration is : " + Sub(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Multi is : " + Mul(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Division is : " + Div(a, b));
                        break;
                    default:
                        Console.WriteLine("Please select correct choice");
                        break;

                }
            }

        }
    }
}
