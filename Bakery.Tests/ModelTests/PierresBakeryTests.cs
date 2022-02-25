using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Model;

namespace Bakery.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BakeryOrder_AnyIntReturnsDingDing_DingDing()
    {
      PierresBakery testBakeryOrder = new PierresBakery();
      Assert.AreEqual("Ding ding!", testBakeryOrder.BakeryOrder(124));
    }

    [TestMethod]
    public void BreadOrder_1Returns5_5()
      {
        PierresBakery testBreadOrder = new PierresBakery();
        Assert.AreEqual(5, testBreadOrder.BreadOrder(1));
      }
  }
}