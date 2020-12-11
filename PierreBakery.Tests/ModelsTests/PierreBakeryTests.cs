using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void OrderCost_CalculatesCostOfBreadOrderWithDeal_Int()
    {
      Bread newOrder = new Bread(5);
      int result = newOrder.OrderCost();
      Assert.AreEqual(20, result);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void OrderCost_CalculatesCostOfPastryOrderWithDeal_Int()
    {
      Pastry newOrder = new Pastry(5);
      int result = newOrder.OrderCost();
      Assert.AreEqual(9, result);
    }
  }
}