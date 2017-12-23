using System;
using System.Collections.Generic;
using Xunit;

namespace CodilityLessons.IMC_EU
{
    class Runner : AlgorithmRunner
    {
        protected override List<Action> Algorithms => new List<Action>()
        {
            RunChallange
        };

        private void RunChallange()
        {
            var sol = new FirstChallange(); 
            Assert.Equal(5, sol.solution(
                new int[] {1,5,4,5,2}, 
                new int[] {2,5,5,5,2}));
            var secondChallange = new SecondChallange();
            Assert.Equal(4, secondChallange.solution(
                new int[] {1,2,3,4}, 
                new int[] {3,3,3,7}));
            Assert.Equal(4, secondChallange.solution(
                new int[] {2,2,2,2,2,2}, 
                new int[] {7,4,2,5,1,2}));
            Assert.Equal(1, secondChallange.solution(
                new int[] {2,2}, 
                new int[] {2,2}));
            Assert.Equal(2, secondChallange.solution(
                new int[] {2,2}, 
                new int[] {1,2}));
            Assert.Equal(2, secondChallange.solution(
                new int[] {3,1000000000}, 
                new int[] {2,1000000000}));
            Assert.Equal(2, secondChallange.solution(
                new int[] {3,1000000000}, 
                new int[] {1000000000,1000000000}));
            // Assert.Equal(0, sol.solution());
            // Assert.Equal(0, sol.solution());
            // Assert.Equal(0, sol.solution());
        }

        protected override string Lesson => "IMC_EU_Runner";
    }
}