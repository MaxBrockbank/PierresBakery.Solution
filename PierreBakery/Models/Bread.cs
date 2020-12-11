using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Bread 
  {
    public int BreadNum {get; set;}
    public int BreadPrice {get; set;}

    public Bread (int order)
    {
      BreadNum = order;
      BreadPrice = order * 5;
    }

    public int OrderCost()
    {
      if(BreadNum % 3 == 0){
        int finalPrice = (BreadNum - (BreadNum/3)) * 5;
        return finalPrice;
      }
      else 
      {
        return BreadPrice;
      }
    }
  }
  
}