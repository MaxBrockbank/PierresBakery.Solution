using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Bread 
  {
    public int OrderNumber {get; set;}
    public int OrderPrice {get; set;}

    public Bread (int order)
    {
      OrderNumber = order;
      OrderPrice = order * 5;
    }

    public int OrderCost()
    {
      if(OrderNumber % 3 == 0){
        int finalPrice = (OrderNumber - (OrderNumber/3)) * 5;
        return finalPrice;
      }
      else 
      {
        return OrderPrice;
      }
    }
  }
  
}