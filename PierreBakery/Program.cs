using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PierreBakery.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. Today we have bread and pastires for sale!");
      Console.WriteLine("What's your name valued customer?");
      string name = Console.ReadLine();
      Console.WriteLine($"How many loaves of bread would you like {name}?");
      int bread = int.Parse(Console.ReadLine());
      Console.WriteLine($"Sounds good! {bread} loaves of bread. How many pastries can I get for you?");
      int pastry = int.Parse(Console.ReadLine());

      Bread breadOrder = new Bread(bread);
      Pastry pastryOrder = new Pastry(pastry);

      Console.WriteLine($"So for {bread} loaves of bread and {pastry} pastries your total comes out to ${breadOrder.OrderCost() + pastryOrder.OrderCost()}. Cash or Card today?");
      string paymentMethod = Console.ReadLine();
      Console.WriteLine(Payment(paymentMethod, name));
    }
    
    static string Payment(string method, string name)
    {
      Regex validPayment = new Regex(@"card|cash" , RegexOptions.IgnoreCase);
      
      if(validPayment.IsMatch(method))
      {
        return $"Have a good day {name}!";
      }
      else 
      {
        return "This isn't a valid payment method. If you want your goods you gotta pay bub.";
      }
    }
  }
}