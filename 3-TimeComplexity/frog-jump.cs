using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TimeComplexity
{
    public class FrogJump
    {
        public int solution(int X, int Y, int D)
        {
            int toBeCrossed = Y - X;
            int stepsNumber = toBeCrossed / D;
            if(toBeCrossed % D > 0) stepsNumber++;
            return stepsNumber;
        }
    }
}