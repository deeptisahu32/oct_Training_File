using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salary;         // calculate salary with bonus
            int years_of_service;
            Console.WriteLine("Enter the salary");
            salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Years");
            years_of_service = Convert.ToInt32(Console.ReadLine());

            if (years_of_service>10)
                Console.WriteLine(salary * 20 / 100 + salary);
            else if (years_of_service >= 5 && years_of_service <= 10)
                Console.WriteLine(salary * 10 / 100 + salary);
            else
                Console.WriteLine(salary * 5 / 100 + salary);
        }
    }
}
