using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4th_ques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeeId;
            string employeeName, Designation;
            decimal salary;
            Console.WriteLine("Enter all employee details employeeId,employeeName,Designation,salary");
            employeeId = Convert.ToInt32(Console.ReadLine());
            employeeName = Console.ReadLine();
            Designation = Console.ReadLine();
            salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Employee Details ----------> \n employeeId {employeeId},{employeeName},{Designation},{salary}");
        }
    }
}
