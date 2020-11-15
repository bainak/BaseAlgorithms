using System;
using BaseAlgorithms.Sorting;

namespace BaseAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            Generator generator = new Generator();
            int[] numbers = generator.GetArray(10);

            var y = numbers.ShellSort();

            long swaps = numbers.Bubble();

            Console.WriteLine("Hello World!");
        }
    }
}
