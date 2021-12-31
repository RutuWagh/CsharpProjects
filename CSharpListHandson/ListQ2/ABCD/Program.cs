using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Con = a(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var i in Con)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<string> a(List<string> nums_str)
        {
            IEnumerable<string> s = nums_str.Select(x => x = x + x + x + x);
            return s.ToList();
        }
        
    }
}
      