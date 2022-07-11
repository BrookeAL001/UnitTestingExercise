using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(5, 7, 3, 15)]
        [InlineData(10, 20, 30, 60)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // DONE create a Calculator object
            var test = new Calculator();

            //Act
            // DONE call the Add method that is located in the Calculator class
            // DONE and store its result in a variable named actual

            var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 0)]//Add test data <-------
        [InlineData(10, 5, 5)]
        [InlineData(5, 10, -5)]

        
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test1 = new Calculator();
            //Act

            var actual = test1.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        [InlineData(10, 5, 50)]
        [InlineData(-10, -20, 200)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test2 = new Calculator();
            //Act
            var actual = test2.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]//Add test data <-------
        [InlineData(50, 5, 10)]
        [InlineData(75, 25, 3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new Calculator();
            //Act
            var actual = test3.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
