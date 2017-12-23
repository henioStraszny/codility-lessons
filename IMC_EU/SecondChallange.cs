using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityLessons.IMC_EU
{
    class SecondChallange
    {
        public int solution(int [] A, int [] B)
        {
            var CounterDict = new Dictionary<int,int>();
            int ACandies = 0;
            int BCandies = 0;
            int ABCandies = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if(!CounterDict.ContainsKey(A[i]))
                {
                    CounterDict.Add(A[i], 1);
                    ACandies++;
                }
                else if(CounterDict[A[i]] == 2)
                {
                    CounterDict[A[i]] = 3;
                    BCandies--;
                    ABCandies++;
                }
                
                if(!CounterDict.ContainsKey(B[i]))
                {
                    CounterDict.Add(B[i], 2);
                    BCandies++;
                }
                else if(CounterDict[B[i]] == 1)
                {
                    CounterDict[B[i]] = 3;
                    ACandies--;
                    ABCandies++;
                }   
            }

            int silverCoins = A.Length / 2;
            int goldCoins = A.Length / 2;
            int numberOfCandies = 0;

            if( ACandies >= silverCoins)
            {
                numberOfCandies += silverCoins;
                silverCoins = 0;
            }
            else
            {
                numberOfCandies += ACandies;
                silverCoins -= ACandies;
            }

            if( BCandies >= goldCoins)
            {
                numberOfCandies += goldCoins;
                goldCoins = 0;
            }
            else
            {
                numberOfCandies += BCandies;
                goldCoins -= BCandies;
            }

            int coinsLeft = silverCoins + goldCoins;

            numberOfCandies += coinsLeft <= ABCandies ? coinsLeft : ABCandies;

            return numberOfCandies;
        }
    }
}