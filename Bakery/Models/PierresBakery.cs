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
     int countedPastries = pastries;
     for (int i = 1; i <= pastries; i++)
     {
      if (countedPastries >= 6) 
      {
        pastryCost += 10;
        countedPastries -= 6;
      } 
      else if (countedPastries == 5)
      {
        pastryCost += 9;
        countedPastries -= 5;
      }
      else if (countedPastries == 4)
      {
        pastryCost += 7;
        countedPastries -= 4;
      }
      else if (countedPastries == 3)
      {
        pastryCost += 5;
        countedPastries -= 3;
      }
      else if (countedPastries >= 1)
      {
        pastryCost += 2;
        countedPastries -= 1;
      }
      else 
      {
        continue;
      }
    }
   return pastryCost;
   }
  }
}