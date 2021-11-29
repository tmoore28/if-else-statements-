using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to guess my favorite number!");
            int favNumber = 7;
            string input = Console.ReadLine();
            int userGuess = int.Parse(input);
                if (userGuess < favNumber)
            {
                Console.WriteLine("Too low");
            }
                else if (userGuess > favNumber)
            {
                Console.WriteLine("Too high");
            }
                else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
