using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFR
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = F(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));
            foreach (var i in list)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<string> F(List<string> str)
        {
            return str.Select(x => x.Replace("a", "")).ToList();
        }
    }
}
