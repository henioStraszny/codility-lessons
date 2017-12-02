using System;
using System.Linq;
using Xunit;

namespace CodilityLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            new IMC_EU.Runner();
            // new CountingElementsRunner();
            // new PrefixSumsRunner();
            // RunTapeEquilibrium();
            // RunMissingElement();
            // RunIterations();
            // RunOddOccurance();
            // RunCyclicRotation();
        }
        private static void RunFrogJump()
        {
            var sol = new TimeComplexity.FrogJump();
            Console.WriteLine("Frog jump test!");
            Console.WriteLine();
            //X = 2; Y = 24; D = 3; Result = 7
            Console.WriteLine(sol.solution(2, 23, 3));
            //X = 345; Y = 1783; D = 34; Result = 43
            Console.WriteLine(sol.solution(345, 1783, 34));
            Console.WriteLine();
        }
        private static void RunTapeEquilibrium()
        {
            var sol = new TimeComplexity.TapeEquilibrium();
            Console.WriteLine("Tape equilibrium test!");
            Console.WriteLine();
            //|3 - 17| = 14
            //|9 - 11| = 2
            //|14 - 6| = 8
            //|18 - 2| = 16
            Console.WriteLine(sol.solution(new int[] { 3, 6, 5, 4, 2 }));
            //|1 - 41| = 40
            //|3 - 39| = 36
            //|10 - 32|= 22
            //|18 - 24|= 6
            //|27 - 15|= 12
            //|31 - 11|= 20
            //|36 - 6| 30
            Console.WriteLine(sol.solution(new int[] { 1, 2, 7, 8, 9, 4, 5, 6 }));
            Console.WriteLine();
        }
        private static void RunMissingElement()
        {
            var sol = new TimeComplexity.PermMissingElement();
            Console.WriteLine("Missing element test!");
            Console.WriteLine();
            Console.WriteLine(sol.solution(new int[] { 3, 6, 5, 4, 2 }));
            Console.WriteLine(sol.solution(new int[] { 1, 2, 7, 8, 9, 4, 5, 6 }));
            Console.WriteLine();
        }
        private static void RunCyclicRotation()
        {
            var sol = new Arrays.CyclicRotation();
            Console.WriteLine("Cyclic rotation test!");
            Console.WriteLine();
            Console.WriteLine(
                string.Join(
                    ", ",
                    sol.solution(new int[] { 2, 3, 5, 3, 2 }, 1)
                    ));
            Console.WriteLine(
                string.Join(
                    ", ",
                    sol.solution(new int[] { 4, 5, 4, 5, 5, 5, 2, 3, 5, 3, 2 }, 3)
                    ));
            Console.WriteLine();
        }
        private static void RunOddOccurance()
        {
            var sol = new Arrays.OddOccuranceInArray();
            Console.WriteLine("Odd Occurance test!");
            Console.WriteLine();
            Console.WriteLine(sol.solution(new int[] { 2, 3, 5, 3, 2 }));
            Console.WriteLine(sol.solution(new int[] { 4, 5, 4, 5, 5, 5, 2, 3, 5, 3, 2 }));
            Console.WriteLine();
        }

        private static void RunIterations()
        {
            var sol = new Iterations.Solution();
            Console.WriteLine("Iteration test!");
            Console.WriteLine();
            Console.WriteLine(sol.solution(1));
            Console.WriteLine(sol.solution(9));
            Console.WriteLine(sol.solution(17));
            Console.WriteLine(sol.solution(65));
            Console.WriteLine(sol.solution(2147483647));
            Console.WriteLine();
        }
    }
}
