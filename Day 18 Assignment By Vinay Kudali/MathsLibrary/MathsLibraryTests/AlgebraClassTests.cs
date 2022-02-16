using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary.Tests
{
    [TestClass()]
    public class AlgebraClassTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            //Arrange
            int input = 0;
            int expected = 1;

            //Act
            int actual = AlgebraClass.Factorial(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_One_to_Seven()
        {
            //Arrange
            int input = 5;
            int expected = 120;

            //Act
            int actual = AlgebraClass.Factorial(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]

        public void FactorialTest_Greater_Than_Seven()
        {
            //Arrange
            int input = 8;
            int expected = -999;

            //Act
            int actual = AlgebraClass.Factorial(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Factorial_Negative_values()
        {
            //Arrange
            int input = -3;
            int expected = -9999;

            //Act
            int actual = AlgebraClass.Factorial(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PalindromeTest()
        {
            //Arrange
            int input = 221;
            string expected = "Not Palindrome";

            //Act
            string actual = AlgebraClass.Palindrome(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PalindromeCheck()
        {
            //Arrange
            int input = 323;
            string expected = "Palindrome";

            //Act
            string actual = AlgebraClass.Palindrome(input);


            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}