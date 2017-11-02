using System;
using System.Linq;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var solution = new Solution();
            int[] array1 = {1,5,3,3,7};
            int[] array2 = {1,4,5,2};
            int[] array3 = {-1,1000000,3647,4};
            int[] array4 = {1,2,5,4};
            int[] array5 = {1,5,4,3};
            int[] array6 = {1,3,5,3,4};
            Console.WriteLine(solution.solution(array1));
            Console.WriteLine(solution.solution(array2));
            Console.WriteLine(solution.solution(array3));
            Console.WriteLine(solution.solution(array4));
            Console.WriteLine(solution.solution(array5));
            Console.WriteLine(solution.solution(array6));
        }
    }
    
}
