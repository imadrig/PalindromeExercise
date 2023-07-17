using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("skate", false)]
        [InlineData("Level" , true)]
        [InlineData("level", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("Morse", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            WordSmith wordPalindromeCheck = new WordSmith();

            //Act
            var actual = wordPalindromeCheck.IsAPalindrome(word);

            //Assert
            Assert.Equal (expected, actual);
        }
    }
}
