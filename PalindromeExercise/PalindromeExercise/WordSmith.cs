using System;
using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            return word.Replace(" ", "").ToLower().SequenceEqual(word.Replace(" ", "").ToLower().Reverse())==true;
        }
    }
}
