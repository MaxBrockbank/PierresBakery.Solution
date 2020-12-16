using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void OrderCost_CalculateOriginalCostOfBread_Int()
    {
      Bread newOrder = new Bread();
      newOrder.Sourdough = 5;
      newOrder.OrderCost(newOrder.Sourdough, newOrder.SourdoughCost);
      int result = 25;
      Assert.AreEqual(result, newOrder.OriginalCost);
    }
    [TestMethod]
    public void OrderCost_CalculatesCostOfBreadOrderWithDeal_Int()
    {
      Bread newOrder = new Bread();
      newOrder.Sourdough = 5;
      int result = newOrder.OrderCost(newOrder.SourdoughCost, newOrder.Sourdough);
      Assert.AreEqual(20, result);
    }
    [TestMethod]
    public void TypeOfBread_UseRegexToValidateFrench_Int()
    {
      Bread newOrder = new Bread();
      int result = newOrder.TypeOfBread("French", 5);
      Assert.AreEqual(40, result);
    }
    [TestMethod]
    public void TypeOfBread_UseRegexToValidateSourdough_Int()
    {
      Bread newOrder = new Bread();
      int result = newOrder.TypeOfBread("Sourdough", 5);
      Assert.AreEqual(20, result);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void OrderCost_CalculateOriginalCostOfPasteries_Int()
    {
      Pastry newOrder = new Pastry(5);
      int result = 10;
      Assert.AreEqual(result, newOrder.OriginalCost);
    }

    [TestMethod]
    public void OrderCost_CalculatesCostOfPastryOrderWithDeal_Int()
    {
      Pastry newOrder = new Pastry(5);
      int result = newOrder.OrderCost();
      Assert.AreEqual(9, result);
    }
  }
}