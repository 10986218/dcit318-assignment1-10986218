using System;

public class GradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your numerical grade (0-100): ");
        int grade;

        if (int.TryParse(Console.ReadLine(), out grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine("Your grade is: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade is: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade is: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade is: D");
            }
            else
            {
                Console.WriteLine("Your grade is: F");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical grade.");
        }
    }
}
