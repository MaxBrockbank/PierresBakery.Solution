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
      Bread newOrder = new Bread(6);
      int result = newOrder.OrderCost();
      Assert.AreEqual(20, result);
    }
  }

  // public class PastryTests
  // {
  //   [TestMethod]

  // }
}