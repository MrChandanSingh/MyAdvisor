
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
            foreach (var fibNumber in fibonacciSeries)
            {
                Console.Write($"{fibNumber} ");
            }
           
            #endregion
            #region check for palindrome string.
            var phrase = "example";
            bool isPalindrome = CheckPhraseIspalindrome(phrase);
            Console.WriteLine($"Is the given phrase palindrome: {isPalindrome}");
            Console.ReadLine();
            #endregion
        }
       
        //The below code has some logical issue, working on it's fixes. 
        private static bool CheckPhraseIspalindrome(string phrase)
        {
            try
            {
                var oddCount = 0;
                var table = new int[(int)(Char.GetNumericValue('z') - Char.GetNumericValue('a') + 1)];
                foreach(var charItem in phrase.ToCharArray())
                {
                    var x = getCharacterNumber(charItem);
                    if (x != -1)
                    {
                        table[x]++;
                        if (table[x] % 2 == 1)
                        {
                            oddCount++;
                        }
                        else
                        {
                            oddCount--;
                        }
                    }
                }
                return oddCount <= 1;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        private static int getCharacterNumber(char charItem)
        {
            var a = (int)Char.GetNumericValue('a');
            var z = (int)Char.GetNumericValue('z');
            var value = (int)Char.GetNumericValue(charItem);
            if(a<=value && value <= z)
            {
                return value - a;
            }
            return -1;
        }

        /// <summary>
        /// Get fibonacci number series.
        /// </summary>
        /// <param name="number">Current given number.</param>
        /// <returns></returns>
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
