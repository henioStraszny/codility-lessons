using System;
using System.Linq;

namespace CountingElements
{
    class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            long[] timeMarker = new long[X];
            long timeMarkerSum = 0;
            
            for (int i = 0; i < A.Count(); i++)
            {
                if (A[i] <= X && timeMarker[A[i] -1] == 0)
                {
                    timeMarker[A[i] -1] = 1;
                    timeMarkerSum++;
                }

                if (timeMarkerSum > X -1)
                    return i;
            }

            return -1;
        }
    }
}