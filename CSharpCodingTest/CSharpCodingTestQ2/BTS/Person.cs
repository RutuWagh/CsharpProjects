using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int ID;

        public Person(string FirstName, string LastName, int Id)
        {
            firstName = FirstName;
            lastName = LastName;
            ID = Id;
        }
        public void Display()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + ID);
        }
    }
}
