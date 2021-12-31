using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Number = D(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in Number)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<int> D(List<int> nums)
        {
            IEnumerable<int> e = nums.Select(x => 5 * (x + 2));
            return e.ToList();

        }

    }
}
