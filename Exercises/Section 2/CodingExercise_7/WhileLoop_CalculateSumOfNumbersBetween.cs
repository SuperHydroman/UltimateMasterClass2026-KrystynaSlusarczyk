using System;

namespace Coding.Exercise
{
    public partial class Exercise
    {
        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            int result = 0;
            
            while(firstNumber <= lastNumber)
                result += firstNumber++;
            
            return result;
        }
    }
}