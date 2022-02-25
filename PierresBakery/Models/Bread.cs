using System;
using System.Collections.Generic;


namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price{ get; set; }

    public Bread (){ } //overloaded Bread constructor
    public Bread (int price)
    {
      Price = price;
    }

    public static int BreadDiscounter( List<Bread> loaves)
    {
      return 0;
    }


  }

}