using System;

namespace Bakery.Model
{
  public class PastryPastry
  {
    public int NumberOfPastries { get; set; }
    public static int PastryOrder (int NumberOfPastries)
    {
      return ((NumberOfPastries / 3) * 5) + ((NumberOfPastries % 3) * 2);
    } 
  }
}