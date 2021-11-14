using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Logging
{
    /// <summary>      
    /// Class StopwatchMeter.      
    /// </summary> 
    public class StopwatchMeter : IAlgorithm
    {
        private readonly IAlgorithm algorithm;

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwatchMeter"/> class.
        /// </summary>
        /// <param name="algorithm">The algorithm for calculate.
        /// </param>
        public StopwatchMeter(IAlgorithm algorithm) =>
            this.algorithm = algorithm ?? throw new ArgumentNullException(nameof(algorithm));

        /// <summary>
        /// Calculates the difference of two integers.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The difference first and second.</returns>
        public int Calculate(int first, int second)
        {
            var stopWatch = Stopwatch.StartNew();
            var result = this.algorithm.Calculate(first, second);
            stopWatch.Stop();
            Console.WriteLine($"Calculate method execution duration is {stopWatch.ElapsedTicks} ticks.");
            return result;
        }
    }
}
