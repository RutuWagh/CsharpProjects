using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHandsonProgrammingQ1
{
    class StudDetails
    {

        public int RollNo;
        public string Name;
        public string Course;
        public int FeesPaid;
        
        public StudDetails(int Rollno, string Stud_Name, String Course_Name)
        {
            RollNo = Rollno;
            Name = Stud_Name;
            Course = Course_Name;
        }
        public void Payment(int amount)
        {
            FeesPaid += amount;
        }
        public void Print()
        {
            Console.WriteLine(" Student_RollNo : " + RollNo);
            Console.WriteLine(" Student_Name   : " + Name);
            Console.WriteLine(" Course_Name    :" + Course);
            Console.WriteLine(" Total_Fees     : " + TotalFee);
            Console.WriteLine(" Fees_Paid      : " + FeesPaid);
            Console.WriteLine(" Due_Amount     : " + DueAmount);
        }
        public int DueAmount
        {
            // int Result;
            get
            {
                return TotalFee - FeesPaid;
            }

        }

        public int TotalFee
        {
            get
            {
                return Course == " " ? 2000 : 3000;
            }
        }
       

        public class Tax
        {
            public double ServiceTax { get; set; }


            public double DueAmount { get; set; }


            public double TotalFee
            {
                get
                {
                    return DueAmount + DueAmount * ServiceTax;
                }
            }


            public Tax()
            {
                ServiceTax = 0.123;
            }
        }
    }
}
