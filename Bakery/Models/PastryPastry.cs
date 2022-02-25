using System;

namespace Bakery.Model
{
  public class PastryPastry
  {
    public int PastryOrder (int numOfPastries)
    {
      int pastryCost = 0;
      while (numOfPastries > 5)
      {
        pastryCost += 10;
        numOfPastries -= 6;
      } 
      pastryCost += numOfPastries + (int)Math.Ceiling(Decimal.Divide(numOfPastries, 2)) + ((numOfPastries - 1) / 3);
      return pastryCost;
    } 
  }
}