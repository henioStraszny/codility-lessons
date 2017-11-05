using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TimeComplexity
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            long left = A[0];
            long right = A.Sum() - A[0];
            long [] P = new long[A.Count() - 1];

            for (int i = 1; i < A.Count(); i++)
            {
                P[i - 1] = Abs(right - left);
                left += A[i];
                right -= A[i];
            }

            return (int)P.Min();
        }

        private long Abs(long number)
        {
            if(number < 0) number *= -1;

            return number;
        }
    }
}