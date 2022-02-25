using System;
using System.Collections.Generic;



namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Price{ get; set; }

    public Pastry( int price )
    {
      Price = price;
    }

    public Pastry() { } //overloaded Pastry constructor

    
    public static int PastryDiscounter( List<Pastry> pastryMountain )
    {
      int totalPrice = 0;
      int pastryInstance = 1;

      foreach (Pastry paste in pastryMountain)
      {
        if( (pastryInstance % 3 == 0) || (pastryInstance % 6 == 0) )
          paste.Price = 1;

        totalPrice += paste.Price;
        pastryInstance++;
      }
      
      return totalPrice;
    }
  }
}