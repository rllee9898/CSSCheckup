
using System;

namespace _00_CustomerChallenge
{
    public class CustomerTwo

    /*
     * Komodo Insurance needs a program that will allow to easily track their customers. 
    For now they only require some basics: a unique customer id number, last name, age, enrollment date, and number of years using Komodo Insurance.
     */


    {

        //properties
        public int CustomerID { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public DateTime enrollmentDate { get; set; }
        public int numberOfYearsUsed { get; set; }

    }
}
