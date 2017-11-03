using System;
using System.Linq;

namespace Iterations
{
    class Solution {
        private int value;
        private string binaryValue;
        private int[] binaryArray;
        public int solution(int n) {
            value = n;
            AssertCorrectValues();
            ConvertToBinary();
            return ComputeBinaryGap();
        }

        private int ComputeBinaryGap()
        {
            int counter = 0;
            int maxSize = 0;
            foreach (var bit in binaryArray)
            {
                if(bit == 0) counter++;
                else 
                {
                    if(counter > maxSize) maxSize = counter;
                    counter = 0;
                }
            }
            return maxSize;
        }

        private void ConvertToBinary()
        {
            binaryValue = Convert.ToString(value, 2); 
            binaryArray = binaryValue.Select(x => int.Parse(x.ToString())).ToArray();
        }
        private void AssertCorrectValues()
        {
            const string NOT_SUPPORT_VALUE = 
                @"This algorithm do not support 
                computation of values lower than 1";

            if(value < 1) 
                throw new NotSupportedException(NOT_SUPPORT_VALUE);
        }
    }
}