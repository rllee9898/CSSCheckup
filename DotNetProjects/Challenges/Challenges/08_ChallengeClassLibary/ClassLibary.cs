using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ChallengeClassLibary
{
    public class ClassLibary
    {
        //POCO *Plain Old C# Object

        //Properties
        //Cust ID 
        //Last Name
        //Age
        //Enroll Date  + Years
        //Store on a list
        //Methods get tested

        public class CustomerInfo
        {
            //Properties
            public int CustID { get; set; }
            public string CustLN { get; set; }
            public int CustAge { get; set; }
            public DateTime CustEnrollDate { get; set; }
        }

        //Constructors (generally these go at the top but they can go anywhere in the class)
        //Constructor Empty

        public ClassLibary() { }
        //Constructor Full
        public ClassLibary(int custID, string custLn, int custAge, DateTime custEnrollDate)
        {
            //CustID = custID;
            //CustLN = CustLn;
            //CustAge = custAge;
            //CustEnrollDate = custEnrollDate;
        }
    }
}