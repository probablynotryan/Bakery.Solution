using System;

namespace Bakery.Model
{
  public class PierresBakery
  {
    public string BakeryOrder(int order)
    {
      return "Ding ding!";
    }
  }
  
  public class BreadBread 
  {
    public int BreadOrder(int breads)
    {
      int breadsCost = 0;
      for (int i = 1; i <= breads; i++)
      {
        if (i % 3 != 0)
        {
          breadsCost += 5;
        }
        else
        {
          continue;
        }
      }
    return breadsCost;
   }
  }

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