using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alienware
{
    class Program
    {
        static void Main(string[] args)
        {
            Lapi A = new Lapi();
            A.Details(Lapi.Lenovo, Lapi.Price, Lapi.Processor, Lapi.RAM, Lapi.HD);

        }
    }
}
