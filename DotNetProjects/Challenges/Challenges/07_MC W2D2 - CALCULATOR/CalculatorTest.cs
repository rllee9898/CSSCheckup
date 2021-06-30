using _03_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ClasseCalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        /// <AAA>
        /// Arrange
        /// Act
        /// Assert

        [TestMethod]
        public void AddMethod_ShouldReturnCorrectValue()
        {
            //Arrange
            Calculator2 calc = new Calculator2();


            int ten = 10;
            int five = 5;
            int expected = 15; 
            //Act
            int actual = calc.Addition(five, ten);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubMethod_ShouldReturnCorrectValue()
        {
            //Arrange
            Calculator2 calc = new Calculator2();


            int ten = 10;
            int five = 5;
            int expected = 5;
            //Act
            int actual = calc.Subtract(five, ten);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MutiplyMethod_ShouldReturnCorrectValue()
        {
            //Arrange
            Calculator2 calc = new Calculator2();


            int five = 5;
            int ten = 10;

            int result = calc.Mutiply(five, ten);
            //Assert
            //  Assert.AreEqual(expectedOutcome, actual);
        }

        [TestMethod]
        public void DivideMethod_ShouldReturnCorrectValue()
        {
            //Arrange
            Calculator2 calc = new Calculator2();


            int ten = 10;
            int two = 2;

            int result = calc.Divide(ten, two);
            //Assert
            // Assert.AreEqual(expectedOutcome, actual);
        }
    }
}