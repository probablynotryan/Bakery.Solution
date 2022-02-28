using System;

namespace Bakery.Model
{
  public class BreadBread 
  {
    public static int Breads { get; set; }
    public static int BreadOrder(int numOfBreads)
    {
      Breads = numOfBreads;
      return ((Breads - (Breads / 3)) * 5);
    }
  }
}