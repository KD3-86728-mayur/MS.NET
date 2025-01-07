using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[2];

            CreateArray(person);
            PrintArray(person);


        }

        static void CreateArray(Person[] person)
        {
            for (int i = 0; i < person.Length; i++)
            {
                person[i].AcceptDetails();

            }

            
        }

        static void PrintArray(Person[] person)
        {
            foreach(Person p in person)
            {
                p.GetDetails();
                Console.ReadLine();
            }
        }
    }

    public struct Person
    {

        public Person(string name, bool zender, int age, int std, char div, double marks)
        {
            _Name = name;
            _Zender = zender;
            _Age = age;
            _Std = std;
            _Div = div;
            _Marks = marks;
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private bool _Zender;

        public bool Zender
        {
            get { return _Zender; }
            set { _Zender = value; }
        }

        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }


        private int _Std;

        public int Std
        {
            get { return _Std; }
            set { _Std = value; }
        }

        private char _Div;

        public char Div
        {
            get { return _Div; }
            set { _Div = value; }
        }

        private double _Marks;

        public double Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter the name");
            _Name =  Console.ReadLine();

            /*Console.WriteLine("Enter gender");
            Zender = Console.ReadLine();*/

            Console.WriteLine("Enter the Age");
            _Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter std");
            _Std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter div");
            String Temp = Console.ReadLine();
            _Div = Temp[0];

            Console.WriteLine("Enter marks");
            _Marks = Convert.ToDouble(Console.ReadLine());
        }

        public void GetDetails()
        {

            Console.WriteLine(_Name);
            Console.WriteLine(_Age);
            Console.WriteLine(_Std);
            Console.WriteLine(_Div);
            Console.WriteLine(_Marks);
        }

    }
}
