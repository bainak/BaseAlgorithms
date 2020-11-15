using System;
using System.Collections.Generic;
using System.Text;

namespace BaseAlgorithms
{
    /// <summary>
    /// Random number generator
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// Сoefficient of the range in which the numbers are generated
        /// </summary>
        private const int _range = 5;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count">The number of elements in the array</param>
        /// <returns></returns>
        public int[] GetArray(int count)
        {
            return RandomStart(count, _range);
        }

        /// <summary>
        /// Returns an array of random numbers with a coefficient
        /// </summary>
        /// <param name="count">The number of elements in the array</param>
        /// <param name="range">Сoefficient of the range in which the numbers are generated</param>
        /// <returns></returns>
        public int[] GetArray(int count, int range)
        {
            return RandomStart(count, range);
        }

        /// <summary>
        /// Generates digits and filled an array with them
        /// </summary>
        /// <param name="count">The number of elements in the array</param>
        /// <param name="range"></param>
        /// <returns></returns>
        private int[] RandomStart(int count, int range)
        {
            var random = new Random();
            var numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(0, count * range);
            }
            return numbers;
        }
    }
}
