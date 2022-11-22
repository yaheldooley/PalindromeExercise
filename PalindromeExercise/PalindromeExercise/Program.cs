using System;
using System.Linq;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class WordSmith
    {
        public bool IsAPalindrome(string s)
        {
            if (s == null || s.Length < 1) return false;
            var reversed = s.ToCharArray();
            reversed.Reverse();
            string answer = new string(reversed);
            return String.Equals(s, answer);
        }
    }
}
