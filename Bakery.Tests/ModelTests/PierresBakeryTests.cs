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
    public void BreadOrder_IntReturnsIntTimesFive_IntTimesFive()
      {
        PierresBakery testBreadOrder = new PierresBakery();
        Assert.AreEqual(5, testBreadOrder.BreadOrder(1));
        Assert.AreEqual(10, testBreadOrder.BreadOrder(2));
      }

    [TestMethod]
    public void BreadOrder_3Returns10_10()
      {
        PierresBakery testBreadOrder = new PierresBakery();
        Assert.AreEqual(10, testBreadOrder.BreadOrder(3));
      }
          [TestMethod]
    public void PastryOrder_6Returns10_10()
      {
        PierresBakery testBreadOrder = new PierresBakery();
        Assert.AreEqual(12, testBreadOrder.PastryOrder(7));
        Assert.AreEqual(2, testBreadOrder.PastryOrder(1));
        Assert.AreEqual(5, testBreadOrder.PastryOrder(3));
        Assert.AreEqual(9, testBreadOrder.PastryOrder(5));
        Assert.AreEqual(10, testBreadOrder.PastryOrder(6));
      }
  }
}