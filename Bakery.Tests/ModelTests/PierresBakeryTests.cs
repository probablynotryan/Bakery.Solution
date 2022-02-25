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
    public void BreadOrder_OneReturnsThree_Three()
      {
        PierresBakery testBreadOrder = new PierresBakery();
        Assert.AreEqual(3, testBreadOrder.BreadOrder(1));
      }
  }
}