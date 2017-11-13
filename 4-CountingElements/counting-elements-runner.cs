using System;
using System.Collections.Generic;
using Xunit;

namespace CodilityLessons
{
    class CountingElementsRunner : CodilityLessons.AlgorithmRunner
    {
        protected override List<Action> Algorithms
        {
            get => new List<Action>() 
            {
                MaxCounters,
                MissingInteger,
                FrogRiverOne,
                PermCheck
            };
        }
        public void MaxCounters()
        {
            var sol = new MaxCounters();
            Assert.Equal(
                expected: new int [] {3,2,2,4,2}, 
                actual: sol.solution(5, new int[] {3,4,4,6,1,4,4})
            );
            Assert.Equal(
                expected: new int [] {4,4,4,4,4}, 
                actual: sol.solution(5, new int[] {3,4,4,6,1,4,4,7})
            );
        }

        public void MissingInteger()
        {
            var sol = new MissingIntegers();
            Assert.Equal(sol.solution(new[] { 1, 3, 6, 4, 1, 2 }), 5);
            Assert.Equal(sol.solution(new[] { 1, 2, 3 }), 4);
            Assert.Equal(sol.solution(new[] { -1, -3 }), 1);
        }

        public void FrogRiverOne()
        {
            var sol = new FrogRiverOne();
            Assert.Equal(sol.solution(3, new int[] { 2, 1, 3 }), 2);
            Assert.Equal(sol.solution(4, new int[] { 2, 1, 3, 4, 5, 6 }), 3);
            Assert.Equal(sol.solution(7, new int[] { 2, 1, 3, 4, 5, 6 }), -1);
        }
        public void PermCheck()
        {
            var sol = new PermCheck();
            Assert.Equal(sol.solution(new int[] { 2, 1, 3 }), 1);
            Assert.Equal(sol.solution(new int[] { 2, 1, 3, 4, 5, 6 }), 1);
            Assert.Equal(sol.solution(new int[] { 2, 1, 3, 4, 6 }), 0);
            Assert.Equal(sol.solution(new int[] { 2, 1, 3, 6, 6 }), 0);
            Assert.Equal(sol.solution(new int[] { 2, 1, 3, 5, 6 }), 0);
            Assert.Equal(sol.solution(new int[] { 2, 23, 3 }), 0);
        }

        protected override string Lesson
        {
            get => "Counting Elements";
        }
    }
}