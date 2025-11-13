using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentques6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Traffic Light
            Console.WriteLine("Enter Traffic Light :");

            string color =Console.ReadLine().ToLower();

            if (color == "red")
                Console.WriteLine("Action -> Stop");
            else if (color == "yellow")
                Console.WriteLine("Action -> Get Ready");
            else if (color == "green")
                Console.WriteLine("Action -> Go");
            else
                Console.WriteLine("This is not Traffic color");

        }
    }
}
