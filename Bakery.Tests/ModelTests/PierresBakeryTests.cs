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
  }
}