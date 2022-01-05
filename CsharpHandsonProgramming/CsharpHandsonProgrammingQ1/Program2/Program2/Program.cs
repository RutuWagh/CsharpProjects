using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student2 s = new Student2(1, "ABC", "asp.net");
            s.Payment(1000);
            s.Print();
            Console.WriteLine(s.DueAmount);

        }
    }
}
