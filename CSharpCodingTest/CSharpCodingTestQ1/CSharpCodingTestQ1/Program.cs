using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingTestQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudDetails sd1 = new StudDetails(1, "Rutuja Wagh", " C# ");
            StudDetails sd2 = new StudDetails(2, "Sakshi Wagh", " ASP ");
            sd1.Payment(1000);
            sd1.Print();
            Console.WriteLine("\n");
            sd2.Payment(1500);
            sd2.Print();

        }
    }
}
