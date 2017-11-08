using System;
using System.Linq;

namespace CountingElements
{
    class MissingIntegers
    {
        public int solution(int[] A)
        {
            int smallestNumber = 1;

            for (int i = 0; i < A.Count(); i++)
            {
                if(A[i] > smallestNumber)
                    smallestNumber = A[i] + 1;
            }

            return smallestNumber;
        }
    }
}