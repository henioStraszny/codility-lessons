using System;
using System.Collections.Generic;

namespace CodilityLessons
{
    abstract class AlgorithmRunner
    {
        protected abstract List<Action> Algorithms 
        {
            get;
        }
        public AlgorithmRunner()
        {
            foreach (var algorithm in Algorithms)
            {
                Run(algorithm);
            }
        }
        private void Run(Action runMethod)
        {
            WriteFunctionName(runMethod.Method.Name);
            runMethod();
            WriteFunctionSuccess();
        }
        protected abstract string Lesson
        {
            get;
        }
        private void WriteFunctionName(string name)
        {
            Console.Write(string.Format("Lesson name: {0}, function name: {1} ====> result: ", Lesson, name));
        }
        
        private void WriteFunctionSuccess()
        {
            Console.WriteLine("Success");
        }
    }
}