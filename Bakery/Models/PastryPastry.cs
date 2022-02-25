using System;

namespace Bakery.Model
{
  public class PastryPastry
  {
    public int PastryOrder (int numOfPastries)
    {
      return (numOfPastries + (int)Math.Ceiling(Decimal.Divide(numOfPastries, 2)) + (numOfPastries / 5));
    } 
  }
}