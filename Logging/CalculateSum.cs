namespace Logging
{
    /// <summary>      
    /// Class CalculateSum.      
    /// </summary>   
    public class CalculateSum : IAlgorithm
    {
        /// <summary>
        /// Calculates the sum of two integers.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The sum first and second.</returns>
        public int Calculate(int first, int second) => first + second;
    }
}
