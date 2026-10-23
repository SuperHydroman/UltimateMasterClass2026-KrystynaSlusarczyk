using System;

namespace Coding.Exercise
{
    public partial class Exercise
    {
        public static int Factorial(int n) 
            => n < 2 ? 1 : n * Factorial(n - 1);
    }
}