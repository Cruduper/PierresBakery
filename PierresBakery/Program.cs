using System;
using System.Collections.Generic;
using PierresBakery.Models;


namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      int cartTotal = 0;
      int numBreads = 0;
      int numPastries = 0;

      Console.WriteLine("Welcome to Pierre's Bakery. The place where there is bread to buy! \nThank you in advance for purchasing from us, Pierre's Bakery, the place where there is bread to buy!");

      Console.Write("\nBe honest, do not lie--how many breads would you like? ");
      numBreads = int.Parse(Console.ReadLine());
      cartTotal += Bread.BreadDiscounter( BreadBaker(numBreads) );
      Console.Write("\nPlease do not lie. You're not good at it, Karl. Everyone sees through your lies. How many pastries would you like? " );
      numPastries = int.Parse(Console.ReadLine());
      cartTotal += Pastry.PastryDiscounter( PastryBaker(numPastries) );

      Console.Write("\n\nYour (dishonest) total for the amount you said you wanted (lies) is: $" + cartTotal + "\n\n");
      
    }

    public static List<Bread> BreadBaker( int nBreads)
    {
      List<Bread> breadList = new List<Bread>();

      for( int i = 0; i < nBreads; i++)
      {
        breadList.Add(new Bread(5));
      }

      return breadList;
    }

    public static List<Pastry> PastryBaker( int nPastries)
    {
      List<Pastry> PastryList = new List<Pastry>();

      for( int i = 0; i < nPastries; i++)
      {
        PastryList.Add(new Pastry(2));
      }

      return PastryList;
    }

  }
}