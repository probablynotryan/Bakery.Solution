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
      Console.WriteLine("How many breads?");
      string inOne = Console.ReadLine();
      Console.WriteLine("How many pastries-es?");
      string inTwo = Console.ReadLine();
      Console.WriteLine("Your total is: $" + (Dog.PastryOrder(int.Parse(inTwo)) + Cat.BreadOrder(int.Parse(inOne))));
    }
  }
}