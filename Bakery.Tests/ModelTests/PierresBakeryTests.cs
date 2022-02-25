using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Model;
using System;

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
    public void BreadOrder_3Returns10_10()
      {
        BreadBread testBreadOrder = new BreadBread();
        Assert.AreEqual(10, testBreadOrder.BreadOrder(3));
      }
          [TestMethod]
    public void PastryOrder_6Returns10_10()
      {
        PastryPastry testPastryOrder = new PastryPastry();
        Assert.AreEqual(12, testPastryOrder.PastryOrder(7));
        Assert.AreEqual(2, testPastryOrder.PastryOrder(1));
        Assert.AreEqual(5, testPastryOrder.PastryOrder(3));
        Assert.AreEqual(9, testPastryOrder.PastryOrder(5));
        Assert.AreEqual(10, testPastryOrder.PastryOrder(6));
      }
  }
}