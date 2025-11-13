using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2ques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Marks;
            Console.WriteLine("Enter Student Marks");
            Marks = Convert.ToInt32(Console.ReadLine());

            if (Marks >= 90)
                Console.WriteLine("+A");
            else if (Marks >= 80 && Marks <= 89)
                Console.WriteLine("A");
            else if (Marks >= 70 && Marks <= 79)
                Console.WriteLine("B");
            else if (Marks >= 60 && Marks <= 69)
                Console.WriteLine("C");
            else if (Marks >= 50 && Marks <= 59)
                Console.WriteLine("D");
            else
                Console.WriteLine("Fail");
        }
    }
}
