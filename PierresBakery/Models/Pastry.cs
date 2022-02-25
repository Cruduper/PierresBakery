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
  }
}