using System;

namespace Logging
{
    /// <summary>      
    /// Class Program.      
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main entry point to the program.
        /// </summary>
        /// <param name="args">Array of arguments.</param>
        static void Main(string[] args)
        {
            int first = 1, second = 2;
            IAlgorithm algorithm = new ServiceLogger(new StopwatchMeter(new CalculateSum()));
            algorithm.Calculate(first, second);
            Console.WriteLine("=================================================");
            algorithm = new ServiceLogger(new StopwatchMeter(new CalculateDifference()));
            algorithm.Calculate(first, second);

            Console.ReadKey();
        }
    }
}
