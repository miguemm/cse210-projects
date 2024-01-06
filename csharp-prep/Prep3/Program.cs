using System;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();
        int magicNumber = random.Next(1,100);
        int guess;
        int count = 0;
        bool play = true;

        while (play)
        {
            Console.WriteLine("Welcome to Try to guess");
            
            do
            {
                count++;
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }else{
                    Console.WriteLine("Higher");
                }

            } while (guess != magicNumber);
            Console.WriteLine($"You guessed it!. # attempts: {count}");

            Console.WriteLine("Keep playing? (yes/no)");
            if (Console.ReadLine() != "yes")
            {
                play = false;
            }

        }


    }
}