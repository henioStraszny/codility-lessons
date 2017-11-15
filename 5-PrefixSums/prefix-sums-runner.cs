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
                PassingCars,
                CountDiv
            };
        }

        private void PassingCars()
        {
            var sol = new PassingCars();

            Assert.Equal(
                expected: 5,
                actual: sol.solution(new int [] {0, 1, 0, 1, 1})
            );
            Assert.Equal(
                expected: 0,
                actual: sol.solution(new int [] {0})
            );
            Assert.Equal(
                expected: 0,
                actual: sol.solution(new int [] {1})
            );
            Assert.Equal(
                expected: 0,
                actual: sol.solution(new int [] {0, 0, 0, 0, 0})
            );
            Assert.Equal(
                expected: 0,
                actual: sol.solution(new int [] {1, 1, 1, 1, 1})
            );
        }

        #region CountDiv
        private void CountDiv()
        {
            var sol = new CountDiv();
            
            Assert.Equal(
                expected: 1,
                actual: sol.solution(0, 0, 2)
            );
            Assert.Equal(
                expected: 3,
                actual: sol.solution(6, 11, 2)
            );
            Assert.Equal(
                expected: 7,
                actual: sol.solution(6, 19, 2)
            );
            Assert.Equal(
                expected: 5,
                actual: sol.solution(3, 23, 4)
            );
            Assert.Equal(
                expected: 0,
                actual: sol.solution(3, 3, 4)
            );
            Assert.Equal(
                expected: 1,
                actual: sol.solution(3, 3, 3)
            );
            Assert.Equal(
                expected: 1,
                actual: sol.solution(3, 4, 4)
            );
            Assert.Equal(
                expected: 3,
                actual: sol.solution(3, 12, 4)
            );
        }
        #endregion
        protected override string Lesson
        {
            get => "PrefixSumsRunner";
        }
    }
}