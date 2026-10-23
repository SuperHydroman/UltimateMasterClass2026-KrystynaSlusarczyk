using System;

namespace Coding.Exercise
{
    public partial class Exercise
    {
        public static string BuildHelloString()
        {
            char[] letters = new [] { 'h', 'e', 'l', 'l', 'o' };
            var result = "";
            for(int i = 0; i < letters.Length; ++i)
            {
                result += letters[i];
            }
            return result;
        }
    }
}