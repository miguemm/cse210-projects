using System;

class Program
{
    static void Main(string[] args)
    {
        int userOption;
        BreathingActivity ba = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity ra = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity la = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        do
        {
            Console.Clear();
            userOption = DisplayMenu();

            switch (userOption)
            {
                case 1 :
                    ba.Run();
                    break;
                case 2 :
                    ra.Run();
                    break;
                case 3 :
                    la.Run();
                    break;
            }
        } while (userOption != 4);
    }

    static int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start breathing activity");
        Console.WriteLine("\t2. Start reflecting activity");
        Console.WriteLine("\t3. Start listing activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Select a choice from the menu: ");

        return int.Parse(Console.ReadLine());
    }

}