using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alienware
{
    class Lapi : Laptop
    {
        
        public void Details(string Name, int Price, string Processor, string RAM, string HD)
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Price :" + Price);
            Console.WriteLine("Processor :" + Processor);
            Console.WriteLine("RAM :" + RAM);
            Console.WriteLine("HD :" + HD);

        }
    }
}
