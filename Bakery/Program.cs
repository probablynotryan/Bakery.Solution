using System;
using Bakery.Model;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Write("Welcome to ");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("Pierre's Bakery. ");
      Console.ResetColor();
      Console.WriteLine("Right now, breads are buy two get one and pastries are buy three get the third one half-off. ");
      Console.Write("How many ");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("breads ");
      Console.ResetColor();
      Console.WriteLine("would you like? ($5/loaf)");
      Console.WriteLine(int.TryParse(Console.ReadLine(), out int thisManyBreads) ? "You got it. " + thisManyBreads + " loaves." : "I prefer numbers, please. Try entering one of those next time. Moving on..");
      Console.Write("How many ");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("pastries ");
      Console.ResetColor();
      Console.WriteLine("would you like? ($2/pastry)");
      Console.WriteLine(int.TryParse(Console.ReadLine(), out int thisManyPastries) ? "No problem. " + thisManyPastries + " pastries." : "I prefer numbers, please. Try entering one of those next time. Moving on..");
      Console.ForegroundColor = ConsoleColor.Green;
      if (thisManyPastries + thisManyBreads == 0)
      {
        Console.WriteLine("None for you today? That's alright. See you next time!");
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("For " + thisManyBreads + " loaves and " + thisManyPastries + " pastries, your total is: $" + (PastryPastry.PastryOrder(thisManyPastries) + BreadBread.BreadOrder(thisManyBreads)) + ". Thanks for coming by!");
      }    
    }
  }
}