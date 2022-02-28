using System;

namespace Bakery.Model
{
  public class PastryPastry
  {
    public int NumberOfPastries { get; set; }
    public int PastryOrder (int pastries)
    {
      NumberOfPastries = pastries;
      return ((NumberOfPastries / 3) * 5) + ((NumberOfPastries % 3) * 2);
    } 
  }
}