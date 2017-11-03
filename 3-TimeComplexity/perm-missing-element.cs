using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TimeComplexity
{
    public class PermMissingElement
    {
        private int[] elements;
        public int solution(int[] A) {
            elements = A;
            
            return FindMissingElement();
        }

        private int FindMissingElement()
        {
            decimal sumOfElements = elements.Select(x => (decimal)x).Sum(x => x);
            decimal sumOfAllElements = 0;

            for (int i = 1; i < elements.Count() + 2; i++)
            {
                sumOfAllElements += i;
            }

            return (int)(sumOfAllElements - sumOfElements);
        }
    }
}