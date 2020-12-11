using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PierreBakery.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. Today we have fresh baked bread and pastires!");
      Console.WriteLine("What's your name valued customer?");
      string name = Console.ReadLine();

      Console.WriteLine("We have two kind of bread today: French for $5 and Sourdough for $10. Which kind would you like?");
      string bread = Console.ReadLine();
      bread = char.ToUpper(bread[0]) + bread.Substring(1);
      Console.WriteLine($"And how many loaves of {bread} bread would you like?");
      int breadAmount = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread();
      int breadCost = breadOrder.TypeOfBread(bread, breadAmount);

      Console.WriteLine($"Sounds good! {breadAmount} loaves of {bread} bread. How many pastries can I get for you? Today they are $2 each or 3 for $5."); 
      int pastry = int.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry(pastry);

      Console.WriteLine($"So for {breadAmount} loaves of {bread}bread and {pastry} pastries your total comes out to ${breadCost + pastryOrder.OrderCost()}. Cash or Card today?");
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