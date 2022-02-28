using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Model;
using System;

namespace Bakery.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadOrder_3Returns10_10()
    {
      BreadBread testBreadOrder = new BreadBread();
      Assert.AreEqual(10, testBreadOrder.BreadOrder(3));
    }
        [TestMethod]
    public void BreadOrder_1Returns5_5()
    {
      BreadBread testBreadOrder = new BreadBread();
      Assert.AreEqual(5, testBreadOrder.BreadOrder(1));
    }
        [TestMethod]
    public void BreadOrder_2Returns10_10()
    {
      BreadBread testBreadOrder = new BreadBread();
      Assert.AreEqual(10, testBreadOrder.BreadOrder(2));
    }

    //pastryorder method tests

    [TestMethod]
    public void PastryOrder_6Returns10_10()
    {
      PastryPastry testPastryOrder = new PastryPastry();
      Assert.AreEqual(10, testPastryOrder.PastryOrder(6));
    }
    [TestMethod]
    public void PastryOrder_3Returns5_5()
    {
      PastryPastry testPastryOrder = new PastryPastry();
      Assert.AreEqual(5, testPastryOrder.PastryOrder(3));
    }
    [TestMethod]
    public void PastryOrder_4Returns7_7()
    {
      PastryPastry testPastryOrder = new PastryPastry();
      Assert.AreEqual(7, testPastryOrder.PastryOrder(4));
    }
    [TestMethod]
    public void PastryOrder_5Returns9_9()
    {
      PastryPastry testPastryOrder = new PastryPastry();
      Assert.AreEqual(9, testPastryOrder.PastryOrder(5));
    }
    [TestMethod]
    public void PastryOrder_18Returns30_30()
    {
      PastryPastry testPastryOrder = new PastryPastry();
      Assert.AreEqual(30, testPastryOrder.PastryOrder(18));
    }
  }
}