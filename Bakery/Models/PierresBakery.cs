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
  }
}