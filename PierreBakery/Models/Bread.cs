using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Bread 
  {
    public int BreadNum {get; set;}

    public Bread (int order)
    {
      BreadNum = order;
    }

    public int OrderCost()
    {
      if(BreadNum % 3 == 0 || (BreadNum > 3 && BreadNum % 3 > 0)){
        int cost = (BreadNum - (BreadNum/3)) * 5;
        return cost;
      }
      else
      {
        return BreadNum * 5;
      }
    }
  }
  
}