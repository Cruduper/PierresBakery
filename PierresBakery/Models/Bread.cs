using System;


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


  }

}