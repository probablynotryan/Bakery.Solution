using System;

namespace Bakery.Model
{
  public class BreadBread 
  {
    public int BreadOrder(int breads)
    {
      return ((breads - (breads / 3)) * 5);
    }
  }
}