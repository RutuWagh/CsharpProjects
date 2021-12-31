using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name: ");
            string firstName  = Console.ReadLine();
            Console.Write("Enter the Last Name : ");
            string lastName = Console.ReadLine();
            //Console.WriteLine("" + firstName + " " + lastName + " ");
            Console.Write("Enter ID : ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the no of scores: ");
            int numScores = Convert.ToInt32(Console.ReadLine());
            int[] testScores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                Console.Write("Enter test score {0}: ", (i + 1));
                testScores[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("---- OUTPUT ----");
            Student s = new Student(firstName, lastName, Id, testScores);
            s.Display();
            Console.WriteLine("Grade: " + s.Calculate());
            //Console.ReadLine();
        }
    }
}
