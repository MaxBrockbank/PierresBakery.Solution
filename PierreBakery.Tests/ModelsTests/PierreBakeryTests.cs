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
      Bread newOrder = new Bread();
      newOrder.Sourdough = 5;
      int result = newOrder.OrderCost(newOrder.SourdoughCost, newOrder.Sourdough);
      Assert.AreEqual(20, result);
    }
    [TestMethod]
    public void TypeOfBread_UseRegexToValidateTypeOfBreadEntered_Int()
    {
      Bread newOrder = new Bread();
      int result = newOrder.TypeOfBread("Sourdough");
      Assert.AreEqual(10, result);
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