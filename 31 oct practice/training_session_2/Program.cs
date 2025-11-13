using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training_session_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 23;
            int num2 = 34;
            float point_score= 3.45f;
            string name = "Deepti sahu";
            double price = 34.123456789;
            decimal tempreture = 34.5m;
            char grade = 'B';

            Console.WriteLine($"num1 value is {num1} \n num2 value is {num2} \n point score is {point_score} \n my name is {name}" +
                $" \n The price is {price} \n The tempreture is {tempreture} \n grade is {grade}");

            Console.ReadLine();
        }
    }
}
