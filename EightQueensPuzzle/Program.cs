using System;

namespace EightQueensPuzzle
{
    class Program
    {
        public static void Main()
        {
            int queensNumber = 8;
            bool isPrintSolutions = true;

            DateTime dt_start = DateTime.Now;

            //Get solution for n-queen puzzle 
            QueensSolutionChecker qsChecker = new QueensSolutionChecker();
            int totalSolutions = qsChecker.GetQueensSolutions(queensNumber, isPrintSolutions);

            DateTime dt_end = DateTime.Now;

            Console.WriteLine($"\n\nThere are {totalSolutions} solutions to the {queensNumber}-Queens problem.");
            Console.WriteLine($"It takes {dt_end.Subtract(dt_start).TotalSeconds} seconds in total.");        

            Console.WriteLine("\n\nPress <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
