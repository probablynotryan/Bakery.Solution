using System;

namespace Bakery.Model
{
  public class PastryPastry
  {
    public int PastryOrder (int pastries)
    {
      int pastryCost = 0;
      while (pastries > 5)
      {
        pastryCost += 10;
        pastries -= 6;
      } 
      if (pastries > 3) 
      {
        pastryCost += pastries + (int)Math.Ceiling(Decimal.Divide(pastries, 2)) + 1;
      }
      else
      {
        pastryCost += pastries + (int)Math.Ceiling(Decimal.Divide(pastries, 2));
      }
    return pastryCost;
    } 
  }
}