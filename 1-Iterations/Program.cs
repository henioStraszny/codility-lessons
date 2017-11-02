using System;
using System.Linq;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            int[] array1 = {1,5,3,3,7};
            Console.WriteLine(sol.Compute(array1));
        }
    }
    
}
