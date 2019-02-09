using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guess box. Will you guess poorly or well?");


            bool firstRiddleSolved = false;
            while (firstRiddleSolved == false)
            {
                Console.Write("Guess a number: ");
                try
                {
                    float weight = Convert.ToSingle(Console.ReadLine());
                    if (weight == 12) firstRiddleSolved = true;
                    else Console.WriteLine("WRONG");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was an exceptionally bad guess");
                }
            }
            Console.WriteLine("You nailed it!");

            bool secondRiddleSolved = false;
            do
            {
                Console.Write("Now guess the next number: ");
                try
                {
                    float weight = Convert.ToSingle(Console.ReadLine());
                    if (weight == 7) secondRiddleSolved = true;
                    else Console.WriteLine("Nope!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was an exceptionally bad guess");
                }
            }
            while (!secondRiddleSolved);

            Console.WriteLine("Nailed it again! Wow, you're *really* good at this.");

            Console.Read();
        }

    }
}
