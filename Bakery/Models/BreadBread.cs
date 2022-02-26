using System;

namespace Bakery.Model
{
  public class BreadBread 
  {
    public int Breads { get; set; }
    public int BreadOrder(int Breads)
    {
      return ((Breads - (Breads / 3)) * 5);
    }
  }
}