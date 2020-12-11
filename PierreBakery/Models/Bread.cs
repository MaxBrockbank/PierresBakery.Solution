using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Bread 
  {
    public int Sourdough {get; set;}
    public int SourdoughCost {get; set;}
    public int French {get; set;}
    public int FrenchCost {get; set;}

    public Bread ()
    {
      Sourdough=0;
      SourdoughCost = 5;
      French=0;
      FrenchCost = 10;
    }

    public int OrderCost(int cost, int typeAmount)
    {
      if(typeAmount % 3 == 0 || (typeAmount > 3 && typeAmount % 3 > 0)){
        int total = (typeAmount - (typeAmount/3)) * cost;
        return total;
      }
      else
      {
        return typeAmount * cost;
      }
    }

    public int TypeOfBread(string typeName)
    {
      return 0;
    }
  }
  
}