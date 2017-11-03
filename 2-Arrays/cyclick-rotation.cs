using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    class CyclicRotation {
        private int[] elements;
        private int numberOfRotations;
        public int[] solution(int[] A, int K) {
            elements = A;
            numberOfRotations = K;
            RotateElements();
            return elements;
        }

        private void RotateElements()
        {
            if(numberOfRotations == 0 || elements.Count() < 2)
                return;
                
            for (int i = 0; i < numberOfRotations; i++)
            {
                SingleRotate();
            }
        }

        private void SingleRotate()
        {
            int temp = elements[elements.Count() - 1];
            for (int i = elements.Count() - 2; i > -1; i--)
            {
                elements[i+1] = elements[i];
            }
            elements[0] = temp;
        }

    }
}