using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type your grade percentage");
        int gradePercentage = int.Parse(Console.ReadLine());
        string grade; 

        if (gradePercentage >= 90)
        {
            grade = "A";
        }
        else if (gradePercentage >=80)
        {
            grade = "B";
        }
        else if (gradePercentage >=70)
        {
            grade = "C";
        }
        else if (gradePercentage >=60)
        {
            grade = "D";
        }else{
            grade = "F";
        }

        int lastDigit = gradePercentage % 10;
        string sign;

        if (lastDigit >= 7 && grade != "A" && grade != "F")
            sign = "+";
        else if (lastDigit < 3 && grade != "F") 
            sign = "-";
        else
            sign = "";


        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congrats!, you approved the class");
        }


        Console.WriteLine($"Your grade is: {grade}{sign}");
    }
}