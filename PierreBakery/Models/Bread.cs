using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace PierreBakery.Models
{
  public class Bread 
  {
    public int Sourdough {get; set;}
    public int SourdoughCost {get; set;}
    public int French {get; set;}
    public int FrenchCost {get; set;}
    public int Total {get; set;}
    public int OriginalCost {get; set;}

    public Bread ()
    {
      Sourdough=0;
      SourdoughCost = 5;
      French=0;
      FrenchCost = 10;
      Total = 0;
    }

    public int OrderCost(int cost, int typeAmount)
    {
      OriginalCost = cost * typeAmount;
      if(typeAmount % 3 == 0 || (typeAmount > 3 && typeAmount % 3 > 0)){
        Total += (typeAmount - (typeAmount/3)) * cost;
        return Total;
      }
      else
      {
        Total += typeAmount * cost;
        return Total;
      }
    }

    public int TypeOfBread(string typeName, int amount)
    {
      Regex sourType = new Regex(@"sourdough", RegexOptions.IgnoreCase);
      Regex frenchType = new Regex(@"french", RegexOptions.IgnoreCase);
      if(sourType.IsMatch(typeName)){
        return OrderCost(SourdoughCost, amount);
      }
      else if (frenchType.IsMatch(typeName))
      {
        return OrderCost(FrenchCost, amount);
      }
      else {
        return 0;
      }
    }
  }
  
}