using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS7
{
    class Person
    {
        public string Name;
       public int Age;
       // public double Height;
        
        public override string ToString()
        {
            return Name + " - " + Age ;
        }

    }
}
