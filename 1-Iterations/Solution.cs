using System;
using System.Linq;

namespace Iteration
{
    class Solution {
        public int solution(int[] A, int D) {
            if(A == null || A.Length > 100000 || D == 0 || D > 100001 || A.Any(x => x > 100000 || x < -1))
                return -1;
            for (int i = 0; i < A.Max(); i++)
            {
                
            }
        }
        public bool solutionOlder(int[] A)
        {
            bool foundFirstPair = false;
            if(A == null || A.Length == 0 || A.Length > 100000)
                return false;

            if(A.Length == 1)
                return true;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] > A[i+1])
                {
                    if(foundFirstPair)
                        return false;

                    for(int j = A.Length -1; j > 0; j--)
                    {
                        if(A[i] > A[j])
                        {
                            Switch(A, i, j);
                            break;
                        }
                    }
                    if(A[i] > A[i+1])
                        return false;

                    foundFirstPair = true;    
                }
            }

            return true;
        }

        private void Switch(int[] A, int firstIndice, int secondIndice)
        {
            int temp;
            if(A == null || A.Length > firstIndice || A.Length > secondIndice)
            {
                temp = A[firstIndice];
                A[firstIndice] = A[secondIndice];
                A[secondIndice] = temp;
            }
        }

        public int solutionOld(int[] A) {

            if(A == null || A.Length == 0)
                return -1;
                
            var b = A.Select(x => (Int64)x).ToArray();
            try
            {
                long rightSum = checked(b.Sum());
                long leftSum = 0;

                for (int i = 0; i < b.Length; i++)
                {
                    if(i > 0)
                        leftSum += b[i-1];

                    rightSum -= b[i];

                    if(leftSum == rightSum)
                        return i;
                }

                return -1;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public void ConvertToBinary(int number)
        {
            if(number == 0) return;

            ConvertToBinary(number/2);
            Console.Write(number%2);

            return;
        }
    }
}