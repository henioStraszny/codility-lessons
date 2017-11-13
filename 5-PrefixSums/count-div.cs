using System;

namespace CodilityLessons
{
    class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            var counter = 0;
            var sum = 0;
            if(A%K == 0)
                sum = A; 
            else
                sum = A - (A%K) + K; 
            while(sum < B)
            {
                counter++;
                sum += K;
            }
            return counter;
        }
    }
}