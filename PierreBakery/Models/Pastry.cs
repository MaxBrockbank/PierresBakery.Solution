using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Pastry 
  {
    public int PastryNum {get; set;}

    public Pastry(int order)
    {
      PastryNum = order;
    }

    public int OrderCost()
    {
      if(PastryNum % 3 == 0)
      {
        int cost = (PastryNum/3) * 5;
        return cost;
      }
      else if(PastryNum % 3 > 0 && PastryNum > 3)
      {
        int cost = ((PastryNum/3) * 5) + ((PastryNum%3) * 2);
        return cost;
      }
      else
      {
        return PastryNum * 2;
      }
    }
  }
  
}