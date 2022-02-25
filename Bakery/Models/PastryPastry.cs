using System;

namespace Bakery.Model
{
  public class PastryPastry
  {
    public int PastryOrder (int numOfPastries)
    {
      return ((numOfPastries / 3) * 5) + ((numOfPastries % 3) * 2);
    } 
  }
}