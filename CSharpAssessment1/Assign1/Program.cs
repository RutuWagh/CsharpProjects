using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. How to count the occurrence of each character in a string?
            Console.WriteLine("Enter a string for count the occurrence of each char operation :");
            string str = Console.ReadLine();
            while (str.Length > 0)
            {
                Console.Write(str[0] + " - ");
                int cal = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);

            }
            Console.WriteLine("---------");
            //2. How to reverse a string?
            Console.WriteLine("Enter a string for reverse operation :");
            string str1 = "", rev = "";
            int Length = 0;
            str1 = Console.ReadLine();
            Length = str1.Length - 1;
            while (Length >= 0)
            {
                rev = rev + str1[Length];
                Length--;
            }
            Console.WriteLine($"Output : {rev}");
            Console.WriteLine("---------");
            //3. How to reverse the order of words in a given string?
            Console.WriteLine("Enter a string for reverse operation :");
            int temp;
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            int k = a.Length - 1;
            temp = k;
            for (int i = k; temp >= 0; k--)
            {
                Console.Write(a[temp] + "" + ' ');
                --temp;
            }
            Console.WriteLine(" ");
            Console.WriteLine("---------");

            //4. How to reverse each word in a given string?
            Console.WriteLine("Enter a String for reverse each word : ");
            string originalString = Console.ReadLine();
            string reverseWordString = string.Join(" ", originalString.Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine($"Output :{reverseWordString}");
            Console.WriteLine("------------");

            //5. How to find all possible substring of a given string?
            Console.WriteLine("Enter a String for find all possible substring of a given string : ");
            string inputString = Console.ReadLine();
            Console.Write("All substrings for given string are : ");
            for (int i = 0; i < inputString.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);
                for (int j = i; j < inputString.Length; ++j)
                {
                    subString.Append(inputString[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.ReadLine();
            Console.WriteLine("-----------");

            //6. How to find second largest integer in an array using only one loop?
            int num, l, z = 0, lrg, lrg2nd;
            int[] arr1 = new int[50];

            Console.Write("Enter the Input the size of array : ");
            num = Convert.ToInt32(Console.ReadLine());

            //Stored values into the array
            Console.Write("Input {0} elements in the array :\n", num);
            for (l = 0; l < num; l++)
            {
                arr1[l] = Convert.ToInt32(Console.ReadLine());
            }
            // find location of the largest element in the array 
            lrg = 0;
            for (l = 0; l < num; l++)
            {
                if (lrg < arr1[l])
                {
                    lrg = arr1[l];
                    z = l;
                }
            }
            // ignore the largest element and find the 2nd largest element in the array 
            lrg2nd = 0;
            for (l = 0; l < num; l++)
            {
                if (l == z)
                {
                    l++;  //ignoring the largest element 
                    l--;
                }
                else
                {
                    if (lrg2nd < arr1[l])
                    {
                        lrg2nd = arr1[l];
                    }
                }
            }
            Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
            Console.ReadLine();
        }
    }
}
