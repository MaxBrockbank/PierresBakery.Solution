using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PierreBakery.Models
{
  public class Program
  {
    static void Main()
    {
      // Console.WriteLine("Welcome to Pierre's Bakery. Today we have fresh baked bread and pastires!");
      // Console.WriteLine("What's your name valued customer?");
      // string name = Console.ReadLine();
      // Console.WriteLine($"How many loaves of bread would you like {name}? Today they are $5 each, but buy two and get one free!");
      // int bread = int.Parse(Console.ReadLine());
      // Console.WriteLine($"Sounds good! {bread} loaves of bread. How many pastries can I get for you? Today they are $2 each or 3 for $5.");
      // int pastry = int.Parse(Console.ReadLine());

      // Bread breadOrder = new Bread();
      // Pastry pastryOrder = new Pastry();

      // Console.WriteLine($"So for {bread} loaves of bread and {pastry} pastries your total comes out to ${breadOrder.OrderCost() + pastryOrder.OrderCost()}. Cash or Card today?");
      // string paymentMethod = Console.ReadLine();
      // Console.WriteLine(Payment(paymentMethod, name));
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