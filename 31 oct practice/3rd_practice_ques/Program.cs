using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_practice_ques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100; // this is in int type and i want to convert into double that will be call implicit conversion
                double value = num;
            Console.WriteLine($"num {num}  and value {value}");

            double pi = 3.14; // now when i convert that double into int so that will be called explicit conversion

            int intpi = (int)pi;
            Console.WriteLine($"pi {pi} and intpi {pi}");

            /*
             * converting value type in object type called boxing
             * and opposit is called unboxing
             */
            object obj = num;
            int myvalue = (int)obj;


            int a = 20;
            int b = a;
            Console.WriteLine($"a value is {a} and b value is {b}");
            b = 34;
            Console.WriteLine($"a value is {a} and b value is {b}");



            string[] name = { "Deepti", "Rishi" };
            string[] copyName = name;
            Console.WriteLine($"name[0] is {name[0]} and name[1] is {name[1]}");
            copyName[0] = "Raju";
            Console.WriteLine($"name[0] is {name[0]} and name[1] is {name[1]}");



        }
    }
}
