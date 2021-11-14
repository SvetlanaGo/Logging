namespace Logging
{
    /// <summary>      
    /// Class CalculateDifference.      
    /// </summary>   
    public class CalculateDifference : IAlgorithm
    {
        /// <summary>
        /// Calculates the difference of two integers.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The difference first and second.</returns>
        public int Calculate(int first, int second) => first - second;
    }
}
