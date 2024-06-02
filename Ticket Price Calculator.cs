using System;

public class TicketPriceCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        double ticketPrice;
        if (age >= 65 || age <= 12)
        {
            ticketPrice = 7.0;
            Console.WriteLine("Discounted ticket price: GHC" + ticketPrice);
        }
        else
        {
            ticketPrice = 10.0;
            Console.WriteLine("Regular ticket price: GHC" + ticketPrice);
        }
    }
}