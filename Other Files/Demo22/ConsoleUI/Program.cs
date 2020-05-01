using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        const string FIRST_NAME = "William";

        static void Main(string[] args)
        {
            int age = 41;
            int num1 = 10;
            double time = 10.5;
            decimal money = 20.00M;
            char middleName = 'T';
            bool isAlive = true;
            string lastName = "Buckwell";

            //Console.WriteLine("My name is " + FIRST_NAME + " and I'm " + age + " years old.");
            //Console.WriteLine("My name is {0} an I'm {1} years old.", FIRST_NAME, age);
            //Console.WriteLine($"My name is {FIRST_NAME} an I'm {age} years old.");
            //Console.WriteLine("My age is " + age + num1);
            double math = 5 / 2;
            Console.WriteLine(math);
            Console.ReadLine();




        }
    }
}
