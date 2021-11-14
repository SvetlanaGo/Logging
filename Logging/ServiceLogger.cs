using Microsoft.Extensions.Logging;
using System;

namespace Logging
{
    /// <summary>      
    /// Class ServiceLogger.      
    /// </summary>
    public class ServiceLogger : IAlgorithm
    {
        private readonly IAlgorithm algorithm;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLogger"/> class.
        /// </summary>
        /// <param name="algorithm">The algorithm for calculate.
        /// </param>
        public ServiceLogger(IAlgorithm algorithm) =>
            this.algorithm = algorithm ?? throw new ArgumentNullException(nameof(algorithm));

        /// <summary>
        /// Calculates the difference of two integers.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The difference first and second.</returns>
        public int Calculate(int first, int second)
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning)
                    .AddFilter("Logging.Program", LogLevel.Information)
                    .AddConsole()
                    .AddDebug();
            });

            ILogger logger = loggerFactory.CreateLogger<IAlgorithm>();
            logger.LogInformation($"{DateTime.Now:MM/dd/yyyy HH:mm} - Calling Calculate() for first = {first} and second = {second}.");
            var result = this.algorithm.Calculate(first, second);
            logger.LogInformation($"{DateTime.Now:MM/dd/yyyy HH:mm} - Calculate() returned '{result}'");

            return result;
        }
    }
}
