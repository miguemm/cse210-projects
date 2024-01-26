using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture s = new Scripture(new Reference("John", "3", "16"), "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        Console.WriteLine(s.GetFormattedScripture());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            s.HideWord();

            Console.Clear();
            Console.WriteLine(s.GetFormattedScripture());

            if (!s.AreVisibleWords())
            {
                return;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            input = Console.ReadLine();
        }

        
    }
}