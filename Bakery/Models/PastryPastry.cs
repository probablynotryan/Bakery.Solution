using System;

namespace Bakery.Model
{
  public class PastryPastry
  {
    public static int NumberOfPastries { get; set; }
    public static int PastryOrder (int pastries)
    {
      NumberOfPastries = pastries;
      return ((NumberOfPastries / 3) * 5) + ((NumberOfPastries % 3) * 2);
    } 
  }
}