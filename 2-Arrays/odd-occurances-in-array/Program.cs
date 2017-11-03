using System;
using System.Linq;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine("Hello World!\n\n");
            Console.WriteLine(sol.solution(new int[]{2,3,5,3,2}));
            Console.WriteLine(sol.solution(new int[]{4,5,4,5,5,5,2,3,5,3,2}));
        }
    }
    
}
