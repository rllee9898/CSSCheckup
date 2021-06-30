
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
        public class Calculator2
    {
        //Methods
        //Method Signature
        //1 Access Modifier
        //2 Return Type
        //3 Name
        //4 Paramaters

        //Add
        //1    //2  //3      //4
        
        
        //Add
        public int Addition(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        
        
        //Sub
        public int Subtract(int numOne, int numTwo)
        {          
            return numOne - numTwo;
        }
        
       
        //Multiply
       public int Mutiply(int numOne, int numTwo)
        {
            int Products = numOne * numTwo;
            return Products;
        }
        
        
        //Divide
        public int Divide(int numOne, int numTwo)
        {
            int powerOfDivision = numOne / numTwo;
            return powerOfDivision;
        }
    }
}