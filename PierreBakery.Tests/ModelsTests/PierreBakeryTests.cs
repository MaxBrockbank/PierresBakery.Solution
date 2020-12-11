using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void OrderCost_CalculatesCostOfOrderWithDeal_Int()
    {
      Bread newOrder = new Bread(3);
      int result = newOrder.OrderCost();
      Assert.AreEqual(10, result);
    }
  }

  // public class PastryTests
  // {
  //   [TestMethod]

  // }
}