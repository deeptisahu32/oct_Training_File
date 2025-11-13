using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_ques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter new number...............");
            //int num;
            //num = Convert.ToInt32(Console.ReadLine());

            //if (num < 0)
            //    Console.WriteLine("Negative nymber");
            //else
            //    Console.WriteLine("$The number is {num}");


            // ABOUT SWITCH

            Console.WriteLine("choose the option => 1.sum , 2.substract , 3.multiplication , 4.Devide");
            int choice = Convert.ToInt32(Console.ReadLine());
            double num1, num2;
            Console.WriteLine("Enter num1 :");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num2 :");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Addition is:" + (num1 + num2));
                    break;
                case 1:
                    Console.WriteLine("Substraction is: " + (num1 - num2));
                    break;
                case 2:
                    Console.WriteLine("Multiplication is: " + (num1 * num2));
                    break;
                case 3:
                    Console.WriteLine("Devide is: " + (num1 / num2));
                    break;
                
                default:
                    Console.WriteLine("out");
                    break;
            }
            Console.ReadLine();

            
        }
    }
}
