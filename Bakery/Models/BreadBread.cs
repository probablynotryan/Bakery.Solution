using System;

namespace Bakery.Model
{
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
}