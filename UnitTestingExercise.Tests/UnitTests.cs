using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(25, 5, 20)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(7, 5, 35)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(70, 35, 2)]
        [InlineData(8, 2, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            
            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact] //parameterless unit test
        public void OutputH()
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = 'h';

            //Assert
            Assert.Equal('h', actual);

        }

        [Fact] //parameterless unit test
        public void HowAreYou()
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = "How are you?";

            //Assert
            Assert.Equal("How are you?", actual);
        }
    }
}
