using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    using System;
    public class Backtracking
    {
       public int[,] solution;
        public void GetQueensPlacedInMatrix()
        {
            Console.WriteLine($"Please enter number to form matrix for placing the queens.");
            var n = Convert.ToInt32(Console.ReadLine());
            solution = new int[n, n];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    solution[i, j] = 0;
                }
            }

            NQuestionProblemSolution(n);
            Console.WriteLine($"After placement of queens into matrix.");
            //Iterating the updated solution and showing to console to see, whether the queens are placed at correct location.
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    Console.Write($"{solution[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();

        }
        void NQuestionProblemSolution(int number)
        {
            //Time complexity is O(n2).


            //Fill palce for queen.
            //Time Complexity is O(N2).
            if (PlaceQueen(0, number))
            {
                //if placing a queen is successfull then print the value.
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write($"{solution[i, j]} ");
                    }

                    Console.WriteLine();
                }
            }
        }

        //Placing a queen one bye one into solution array, column wise.
        bool PlaceQueen(int queen, int number)
        {
            if (queen == number)
                return true;
            //Check if queen can be placed.
            for (var row = 0; row < number; row++)
            {
                if (!CanPlaceQueen(row, queen)) continue;
                solution[row, queen] = 1;
                if (PlaceQueen(queen + 1, number))
                {
                    return true;
                }

                //Backtracking
                solution[row, queen] = 0;
            }

            return false;
        }

        //// check if queen can be placed at solution[row][column]
        bool CanPlaceQueen(int row, int column)
        {
            //checking if one queen placed in that row.
            for (var i = 0; i < column; i++)
            {
                if (solution[row, i] == 1)
                {
                    return false;
                }

            }

            //upper diagonal
            for (int i = row, j = column; i >= 0 && j >= 0; i--, j--)
            {
                if (solution[i, j] == 1)
                    return false;
            }

            //A lower diagonal.
            for (int i = row, j = column; i < solution.GetLength(0) && j >= 0; i++, j--)
            {
                if (solution[i, j] == 1)
                    return false;
            }

            return true;
        }


    }
}
