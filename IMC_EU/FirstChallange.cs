using System;
using System.Linq;

namespace CodilityLessons.IMC_EU
{
    public class FirstChallange
    {
        public int solution(int [] A, int [] B)
        {
            int[] numberOfPairs = new int [7];
            int[] existsSingular = new int [7];

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] == B[i])
                    numberOfPairs[A[i]]++;
                else
                {
                    existsSingular[A[i]]++;
                    existsSingular[B[i]]++;
                }
            }

            int biggest = numberOfPairs.Max();
            int elementNumber = numberOfPairs.First(x => x == biggest);
            biggest *= 2;

            if(existsSingular[elementNumber] == 1)
                biggest++;
            else if (existsSingular[elementNumber] > 1)
                biggest +=2;

            return biggest;
        }
    }
}