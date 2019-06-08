
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            #region N-Queens Problem(Backtracking)
            Backtracking backtracking = new Backtracking();
            backtracking.GetQueensPlacedInMatrix();
            #endregion

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
            #endregion
            #region Longest common sequence in given X & Y pattern.
            var firstString = "ACBDEA";
            var secondString = "ABCDA";
            var lengthOfFirstString = firstString.Length;
            var lengthOfSecondString = secondString.Length;
            var intArray = new int[lengthOfFirstString + 1, lengthOfSecondString + 1];
            var stringArray = new string[lengthOfFirstString + 1, lengthOfSecondString + 1];
            //n
            for (var i = 0; i <= lengthOfFirstString; i++)
            {
                intArray[i, 0] = 0;
            }
            //n
            for (var j = 0; j <= lengthOfSecondString; j++)
            {
                intArray[0, j] = 0;
            }

            ////n
            for (int i = 1; i <= lengthOfFirstString; i++)
            {
                //n
                for (int j = 1; j <= lengthOfSecondString; j++)
                {
                    if (firstString[i - 1] == secondString[j - 1])
                    {
                        intArray[i, j] = intArray[i - 1, j] + 1;
                        stringArray[i, j] = "D";
                    }
                    else if (intArray[i - 1, j] >= intArray[i, j - 1])
                    {
                        intArray[i, j] = intArray[i - 1, j] + 1;
                        stringArray[i, j] = "U";
                    }
                    else
                    {
                        intArray[i, j] = intArray[i, j - 1] + 1;
                        stringArray[i, j] = "L";
                    }
                }
            }
            ////output=2n+n2=n2
            var answer = string.Empty;
            int k = lengthOfFirstString, l = lengthOfSecondString;
            while (true)
            {
                if (k == 0 && k == 0)
                    break;
                if (stringArray[k, l] == "D")
                {
                    answer = firstString[k - 1] + answer;
                    k--;
                    l--;
                }

                if (stringArray[k, l] == "U")
                {
                    k--;
                }

                if (stringArray[k, l] == "L")
                {
                    l--;
                }
            }
            Console.Write(answer);
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
                foreach (var charItem in phrase.ToCharArray())
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
            if (a <= value && value <= z)
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
