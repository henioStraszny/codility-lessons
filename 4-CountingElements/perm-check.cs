using System;
using System.Linq;

namespace CountingElements
{
    class PermCheck
    {
        /// Check whether array is permutation
        /// returns:
        /// 0 - not permutation
        /// 1 - is permutation
        public int solution(int[] A)
        {
            int lenght = A.Count();
            int[] counter = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                if (A[i] > lenght || A[i] == 0)
                    return 0;

                counter[A[i] - 1]++;

                if (counter[A[i] - 1] > 1)
                    return 0;
            }

            return counter.Any(x => x == 0) ? 0 : 1;
        }
    }
}