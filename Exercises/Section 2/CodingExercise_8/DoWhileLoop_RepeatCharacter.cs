using System;

namespace Coding.Exercise
{
    public partial class Exercise
    {
        public static string RepeatCharacter(char character, int targetLength)
        {
            int currentIndex = 0;
            string result = "";
                    
            do
            {
                result += character;
                currentIndex++;
            } while (currentIndex < targetLength);
                    
            return result;
        }
    }
}