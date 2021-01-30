using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EightQueensPuzzle
{
    public class QueensSolutionChecker
    {
        private int _queens;
        private bool _isPrint = true;
        private string[,] _board;
        private int _totalSolutions;
        private const string QUEEN_STRING = "Q";
        private const string EMPTY_STRING = ".";

        public QueensSolutionChecker()
        {
        }
        /*
           This function solves the N Queen problem using Backtracking. 
           It mainly uses solveNQUtil() to solve the problem.
           It returns false if queens cannot be placed, otherwise return true and prints placement of queens in the form of 1s.
           Please note that there may be more than one solutions, this function prints one of the feasible solutions.
        */
        /// <summary>
        /// This function solves the N Queen problem using Backtracking. 
        /// </summary>
        /// <param name="queensNumber"></param>
        /// <param name="isPrintSolutions"></param>
        /// <returns>Total Solutions count</returns>
        public int GetQueensSolutions(int queensNumber, bool isPrintSolutions)
        {
            _queens = queensNumber;
            _isPrint = isPrintSolutions;
            _totalSolutions = 0;

            _board = new string[_queens, _queens];

            if (SolveQueensUtil(0) == false)
            {
                Console.Write("Solution does not exist");
                _totalSolutions = 0;
            }

            return _totalSolutions;
        }

        //A recursive utility function to solve N Queen problem
        private bool SolveQueensUtil(int col)
        {
            //base case: If all queens are placed then return true
            if (col == _queens)
            {
                _totalSolutions++;

                if (_isPrint)
                {
                    PrintSolution(_totalSolutions);                    
                }

                return true;
            }

            //Consider this column and try placing this queen in all rows one by one 
            bool res = false;
            for (int i = 0; i < _queens; i++)
            {
                // Check if queen can be placed on board[i,col]
                if (IsSafe(i, col))
                {
                    //Place this queen in board[i,col]
                    _board[i, col] = QUEEN_STRING;

                    // Make result true if any placement is possible 
                    res = SolveQueensUtil(col + 1) || res;

                    //If placing queen in board[i,col] doesn't lead to a solution, then remove queen from board[i,col]
                    _board[i, col] = EMPTY_STRING; // BACKTRACK 
                }
            }

            //If queen can not be place in any row in this column col then return false
            return res;
        }

        /* 
         A utility function to check if a queen can be placed on board[row,col]. 
         Note that this function is called when "col" queens are already placed in columns from 0 to col -1. 
         So we need to check only left side for attacking queens 
        */
        private bool IsSafe(int row, int col)
        {
            int i, j;

            //Check this row on left side
            for (i = 0; i < col; i++)
                if (_board[row, i] == QUEEN_STRING)
                    return false;

            //Check upper diagonal on left side
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (_board[i, j] == QUEEN_STRING)
                    return false;

            //Check lower diagonal on left side
            for (i = row, j = col; j >= 0 && i < _queens; i++, j--)
                if (_board[i, j] == QUEEN_STRING)
                    return false;

            return true;
        }

        //A utility function to print solution
        private void PrintSolution(int solutionNumber)
        {
            Console.WriteLine("\n\n//Solution {0}", solutionNumber);
            //for (int i = 0; i < _queens; i++)
            for (int i = _queens-1; i >= 0; i--)
            {
                string[] row = new string[_queens];
                for (int j = 0; j < _queens; j++)
                {
                    row[j] = _board[i, j]== QUEEN_STRING ? QUEEN_STRING : EMPTY_STRING;
                }
                Console.WriteLine(string.Join("", row));
            }

        }       
        
    }
}
