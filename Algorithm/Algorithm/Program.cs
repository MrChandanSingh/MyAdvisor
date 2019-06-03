
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            #region Get fibonacci series using generic collection.
            var number = 30;
            IEnumerable<int> fibonacciSeries = GetFibonacciSeries(number);
            foreach(var fibNumber in fibonacciSeries)
            {
                Console.Write($"{fibNumber} ");
            }
            Console.ReadLine();
            #endregion
        }

        private static IEnumerable<int> GetFibonacciSeries(int number)
        {
            var prev = -1;
            int next = 1;
            for (var i = 0; i < number; i++)
            {
                var sum = prev + next;
                prev = next;
                next = sum;
                //using defered execution concept.
                yield return sum;
            }
        }
    }
}
