using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CodilityLessons
{
    class MissingIntegers
    {
        public int solution(int[] A)
        {
            var countingTable = new int[1000001] ;
            countingTable[0] = 1;

            for (int i = 0; i < A.Count(); i++)
            {
                if(A[i] > 0 && countingTable[A[i]] == 0)
                    countingTable[A[i]] = 1;
            }

            int counter = 0;

            while(countingTable[counter] > 0)
            {
                counter++;
            }

            return counter;
        }
    }
}