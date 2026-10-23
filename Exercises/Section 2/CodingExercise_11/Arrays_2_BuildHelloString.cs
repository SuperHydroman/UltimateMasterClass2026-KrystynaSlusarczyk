using System;

namespace Coding.Exercise
{
    public partial class Exercise
    {
        public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
        {
            foreach(string word in words)
                if (word == wordToBeChecked)
                    return true;
            
            return false;
        }
    }
}