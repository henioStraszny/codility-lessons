using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    class OddOccuranceInArray {
        private int[] elements;
        public int solution(int[] A) {
            elements = A;
            AssertCorrectValues();
            return FindOdd3();
        }

        private int FindOdd3()
        {
            var groupped = new Dictionary<int,int>();

            for (int i = 0; i < elements.Count(); i++)
            {
                if(groupped.ContainsKey(elements[i]))
                    groupped[elements[i]]++;
                else
                    groupped.Add(elements[i], 1);
            }

            return groupped.First(x => x.Value % 2 > 0).Key;
        }
        private int FindOdd2()
        {
            var storage = elements.ToList();
            var groupped = storage.GroupBy(x => x);
            return groupped.First(x => x.Count() % 2 == 1).Key;
        }

        private int FindOdd()
        {
            var storage = new List<int>();
            storage.Add(elements[0]);

            for (int i = 1; i < elements.Count(); i++)
            {
                if(storage.Any(x => x == elements[i]))
                    storage.Remove(elements[i]);
                else
                    storage.Add(elements[i]);
            }
            return storage.First();
        }

        private void AssertCorrectValues()
        {
            const string ELEMENTS_NUMBER_EVEN_NUMBER = 
                @"Number of elements is an even number.";
            const string ELEMENTS_NUMBER_EXCEED_MILION = 
                @"Number of elements is largen than 1 000 000.";
            const string ELEMENT_EXCEED_BILION =
                "There is element, larger than 1 000 000 000";

            if(elements.Count() % 2 == 0) 
                throw new NotSupportedException(ELEMENTS_NUMBER_EVEN_NUMBER);
            if(elements.Count() > 1000000) 
                throw new NotSupportedException(ELEMENTS_NUMBER_EXCEED_MILION);
            if(elements.Any(x => x > 1000000000) )
                throw new NotSupportedException(ELEMENT_EXCEED_BILION);
        }
    }
}