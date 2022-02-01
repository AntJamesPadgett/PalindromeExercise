using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void MyTest(string word, bool expected)
        {

            //arrange
            var tester = new WordSmith();

            //act
            var actaual = tester.isAPalindrome();

            //assert
            Assert.Equal(expected, actaual);
        }
    }
}
