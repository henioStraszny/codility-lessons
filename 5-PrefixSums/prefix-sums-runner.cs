using System;
using System.Collections.Generic;
using Xunit;

namespace CodilityLessons
{
    class PrefixSumsRunner : AlgorithmRunner
    {
        protected override List<Action> Algorithms
        {
            get => new List<Action>() 
            {
                CountDiv
            };
        }
        private void CountDiv()
        {
            var sol = new CountDiv();
            Assert.Equal(
                expected: 3,
                actual: sol.solution(6, 11, 2)
            );
        }
        protected override string Lesson
        {
            get => "PrefixSumsRunner";
        }
    }
}