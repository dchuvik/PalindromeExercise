using System;
using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse())==true;
        }
    }
}
