using System;
using System.Linq;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            WordSmith smith = new WordSmith();
            smith.IsAPalindrome("bottle");
        }
    }

    public class WordSmith
    {
        public bool IsAPalindrome(string s)
        {
            if (s == null || s.Length < 1) return false;
            var reversed = s.ToCharArray().Reverse();
            string answer = string.Join("", reversed);
			return String.Equals(s, answer);
        }
    }
}
