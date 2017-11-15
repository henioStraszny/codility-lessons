using System;

namespace CodilityLessons
{
    class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            var left = 0;
            if(A == 0)
            {
                left = -1;
                if(B == 0)
                    return 1;
            }
            else
            {
                left = A%K == 0 ? (A-1)/K: A/K;
            }

            var right = B/K;

            return right - left;
        }
    }
}