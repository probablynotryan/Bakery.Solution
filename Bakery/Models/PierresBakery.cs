using System;
using System.Text;

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
    int pastryCost = 0;
    while (pastries >= 6)
    {
      pastryCost += 10;
      pastries -= 6;
    } 
    if (pastries == 5)
    {
      pastryCost += 9;
      return pastryCost;
    }
    else if (pastries == 4)
    {
      pastryCost += 7;
      return pastryCost;
    }
      else if (pastries == 3)
      {
        pastryCost += 5;
        return pastryCost;
      }
      else if (pastries == 2)
      {
        pastryCost += 4;
        return pastryCost;
      } 
      else if (pastries == 1)
      {
        pastryCost += 2;
        return pastryCost;
      }
      else
      {
      return pastryCost;
      }
   }
  }
}