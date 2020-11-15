using System;
using System.Collections.Generic;
using System.Text;

namespace BaseAlgorithms.Sorting
{
    /// <summary>
    /// Represents the standard sorting algorithms for the integer type
    /// </summary>
    public static class ArrayIntExtension
    {
        /// <summary>
        /// Bubble sorting for integer array
        /// </summary>
        /// <param name="array">Integer array</param>
        /// <returns>Count of swaps</returns>
        public static long Bubble(this int[] numbers)
        {
            long swaps = 0;
            for (int count = numbers.Length; count > 0; count--)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int number = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = number;
                        swaps++;
                    }
                }
            }

            return swaps;
        }

        /// <summary>
        /// Insert sorting for integer array
        /// </summary>
        /// <param name="numbers">Integer array</param>
        /// <returns>Count of swaps</returns>
        public static long InsertSort(this int[] numbers)
        {
            long swaps = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int x = i; (x > 0) && (numbers[x - 1] > numbers[x]); x--)
                {
                    int tempVal = numbers[x - 1];
                    numbers[x - 1] = numbers[x];
                    numbers[x] = tempVal;
                    swaps++;
                }
            }
            return swaps;
        }

        /// <summary>
        /// Cocktail sorting for integer array
        /// </summary>
        /// <param name="numbers">Integer array</param>
        /// <returns>Count of swaps</returns>
        public static long CocktailSort(this int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;
            long swaps = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int number = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = number;
                        swaps++;
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        int number = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = number;
                        swaps++;
                    }
                }

                left++;
            }
            return swaps;
        }

        /// <summary>
        /// Shellg sorting for integer array
        /// </summary>
        /// <param name="numbers">Integer array</param>
        /// <returns>Count of swaps</returns>
        public static long ShellSort(this int[] numbers)
        {
            // TODO: stuck on this algorithm
            int part = 2;
            int staps = numbers.Length / part;
            long swaps = 0;
            while (staps > 0)
            {

                for (int i = 0; i < staps; i++)
                {
                    for (int x = staps; x > 0; x--)
                    {
                        if (numbers[staps - x] > numbers[x])
                        {
                            int tempVal = numbers[staps - x];
                            numbers[staps - x] = numbers[x];
                            numbers[x] = tempVal;
                            swaps++;
                        }
                    }
                }
                staps /= 2;
            }
            return swaps;
        }
    }
}
