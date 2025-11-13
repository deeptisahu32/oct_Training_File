using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondpracticecode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName, LastName;
            int age;
            char grade;
            int score1, score2, score3, score4;
            Console.WriteLine("Enter All values --> FirstName,LastName,age,grade,score1,score2,score3,score4");
            FirstName = Console.ReadLine();
            LastName = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            grade = Convert.ToChar(Console.ReadLine());
            score1= Convert.ToInt32(Console.ReadLine());
            score2= Convert.ToInt32(Console.ReadLine());
            score3= Convert.ToInt32(Console.ReadLine()); 
            score4= Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Student_Score_Card ----------------------->\n");
            Console.WriteLine($"FirstName,LastName={FirstName}{LastName}");
            Console.WriteLine($"age and grade = {age}, {grade}");
            Console.WriteLine($"score1,score2,score3,score4={score1},{score2},{score3},{score4}");



        }
    }
}
