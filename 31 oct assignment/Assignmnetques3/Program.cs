using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnetques3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Purchase_amount;
            Console.WriteLine("Enter Purchase Amount:");
            Purchase_amount = Convert.ToInt32(Console.ReadLine());
            if (Purchase_amount > 5000)
                Console.WriteLine("Total amount after discount:" + ((Purchase_amount)-Purchase_amount*20 / 100));
            else if (Purchase_amount >=1000 && Purchase_amount <= 5000)
                Console.WriteLine("Total amount after discount: " + ((Purchase_amount)-Purchase_amount * 10 / 100));
            else
                Console.WriteLine("Total amount after discount: " + "No Discount");
        }
    }
}
