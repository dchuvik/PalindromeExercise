using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("civic", true)]
        [InlineData("repaper", true)]
        [InlineData("David", false)]
        [InlineData("TrueCoders", false)]


        public void Test1(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();
            //act
            var actual = tester.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
