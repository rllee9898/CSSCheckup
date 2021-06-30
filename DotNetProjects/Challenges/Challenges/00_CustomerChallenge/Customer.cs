using System;

namespace _00_CustomerChallenge
{
    /*a unique customer id number
     *last name
     *age
     *enrollment date, 
     *number of years using Komodo Insurance.*/


    public class Customer
    {
        //properties
        
       // access modifier // type // Property Name // Get Set

         public int CustomerID { get; set; }
         public string LastName { get; set; }
         public int Age { get; set; }
         public DateTime EnrollmentDate { get; set; }
         public int NumberOfYearsUsed { get; set; }
    }
}
