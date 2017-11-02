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
            Console.WriteLine(sol.solution(1));
            Console.WriteLine(sol.solution(9));
            Console.WriteLine(sol.solution(17));
            Console.WriteLine(sol.solution(65));
            Console.WriteLine(sol.solution(2147483647));
        }
    }
    
}
