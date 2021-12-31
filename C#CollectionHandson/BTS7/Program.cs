using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BTS7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("---- Input -----");
            Stack s = new Stack();
            Queue q = new Queue();
            int total = 3;
            for (int i = 0; i < total; i++)
            {
                Console.Write("Person Name : ");
                string name = Console.ReadLine();
                Console.Write("Person Age : ");
                int age = Convert.ToInt32(Console.ReadLine());
              //  Console.Write("Person's Height : ");
               // double height = Convert.ToDouble(Console.ReadLine());
                list.Add(new Person()
                {
                    Name = name,
                    Age = age
                  //  Height = height
                });
                s.Push(new Person()
                {
                    Name = name,
                    Age = age
                });
                q.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });

            }

            Console.WriteLine("---- ListOutput ----");
            foreach (Person a in list)
            {
                Console.WriteLine(a.ToString());
            }
            Console.ReadLine();
            Console.WriteLine("----- StackOutput -----");
            for(int i = 0; i< total; i++)
            {
                Person p = (Person)s.Pop();
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();
            Console.WriteLine("----- QueueOutput -----");
            /* foreach(Person f in q)
             {
                 Console.WriteLine(f.ToString());
             }
             Console.ReadLine();*/
            for (int i = 0; i < total; i++)
            {
                Person p1 = (Person)q.Dequeue();
                Console.WriteLine(p1.ToString());
            }
        }

        /*
        D d1= new D { Name = "John", Age = 12 };
        Console.WriteLine(d1);*/
    }
}

    


