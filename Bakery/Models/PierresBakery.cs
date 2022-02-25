using System;

namespace Bakery.Model
{
  public class PierresBakery
  {
    public string BakeryOrder(int order)
    {
      return "Ding ding!";
    }

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

    public int PastryOrder (int pastries)
    {
      double pastryCost = 0;
      while (pastries > 5)
      {
        pastryCost += 10;
        pastries -= 6;
      } 
      double remainder = Convert.ToDouble(pastries/2);
      pastryCost += Math.Ceiling(remainder) + 1;
      return pastryCost;
    }
  
  }
}