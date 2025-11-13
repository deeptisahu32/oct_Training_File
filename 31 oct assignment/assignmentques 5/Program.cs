using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentques_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Restaurent bill

            int bill,number_of_people;
            Console.WriteLine("Enter Bill Amount :");
            bill = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total people :");
            number_of_people = Convert.ToInt32(Console.ReadLine());

            if (bill > 1000)
                Console.WriteLine($"Each Person should pay : {(bill * 5 * 10 / 100 + bill) / number_of_people}");
            else
                Console.WriteLine($"Each Person should pay : {bill / number_of_people}");


        }
    }
}
