using System;
using Bakery.Model;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      BreadBread Cat = new BreadBread();
      PastryPastry Dog = new PastryPastry();
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
      string inOne = Console.ReadLine();
      Console.Write("How many ");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("pastries ");
      Console.ResetColor();
      Console.WriteLine("would you like? ($2/pastry)");
      string inTwo = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Your total is: $" + (Dog.PastryOrder(int.Parse(inTwo)) + Cat.BreadOrder(int.Parse(inOne))));
    }
  }
}