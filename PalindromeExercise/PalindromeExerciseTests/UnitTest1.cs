using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
		[Theory]
		[InlineData("noon", true)]
		[InlineData("bottle", false)]

		// For example [InlineData(“racecar”, true)]
		public void IsPalindrome(string s, bool expected)
		{
			var wordSmith = new WordSmith();

			var actual = wordSmith.IsAPalindrome(s);

			Assert.Equal(expected, actual);
		}
    }
}
