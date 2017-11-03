using System;
using System.Linq;

namespace CodilityLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMissingElement();
            // RunIterations();
            // RunOddOccurance();
            // RunCyclicRotation();
        }

        private static void RunMissingElement()
        {
            var sol = new TimeComplexity.PermMissingElement();
            Console.WriteLine("Odd Occurance test!");
            Console.WriteLine();
            Console.WriteLine(sol.solution(new int[]{3,6,5,4,2}));
            Console.WriteLine(sol.solution(new int[]{1,2,7,8,9,4,5,6}));
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
                    sol.solution(new int[]{2,3,5,3,2}, 1)
                    ));
            Console.WriteLine(
                string.Join(
                    ", ", 
                    sol.solution(new int[]{4,5,4,5,5,5,2,3,5,3,2},3)
                    ));
            Console.WriteLine();
        }

        private static void RunOddOccurance()
        {
            var sol = new Arrays.OddOccuranceInArray();
            Console.WriteLine("Odd Occurance test!");
            Console.WriteLine();
            Console.WriteLine(sol.solution(new int[]{2,3,5,3,2}));
            Console.WriteLine(sol.solution(new int[]{4,5,4,5,5,5,2,3,5,3,2}));
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
