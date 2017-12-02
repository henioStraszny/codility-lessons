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
            var sol = new Challange(); 
            Assert.Equal(0, sol.Solution());
            Assert.Equal(0, sol.Solution());
            Assert.Equal(0, sol.Solution());
            Assert.Equal(0, sol.Solution());
        }

        protected override string Lesson => "IMC_EU_Runner";
    }
}