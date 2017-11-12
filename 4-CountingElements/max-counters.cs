using System;

namespace CountingElements
{
    class MaxCounters
    {
        public int [] solution(int N, int[] A)
        {
            var counters = new int[N];
            var maxCounter = 0;
            var currentCounter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                var item = A[i];
                if(item >= 1 && item <= N)
                {
                    if(counters[item - 1] <= currentCounter)
                        counters[item - 1] = currentCounter + 1;
                    else
                        counters[item - 1]++;
                    if(counters[item - 1] > maxCounter)
                        maxCounter = counters[item - 1];
                }
                else if(item > N)
                {
                    currentCounter = maxCounter;
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                if(counters[i] < currentCounter)
                    counters[i] = currentCounter;
            }

            return counters;
        }
    }
}