using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Pastry 
  {
    public int PastryNum {get; set;}
    public int PastryPrice {get; set;}

    public Pastry(int order)
    {
      PastryNum = order;
      PastryPrice = order * 2;
    }

    public int OrderCost()
    {
      return 0;
    }
  }
  
}