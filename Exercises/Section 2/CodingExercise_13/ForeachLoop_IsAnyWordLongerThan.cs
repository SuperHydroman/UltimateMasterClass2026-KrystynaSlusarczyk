using System;

namespace Coding.Exercise
{
    public partial class Exercise
    {
        public static bool IsAnyWordLongerThan(int length, string[] words)
        {
            foreach (string word in words)
            {
                if (word.Length > length) return true;
            }
            
            return false;
        }
    }
}