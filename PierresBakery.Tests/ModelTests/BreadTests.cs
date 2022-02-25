using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;


namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfItemBread_BreadInstance()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void SetPrice_SetsPriceOfBreadTo5_5()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Bread newBread = new Bread();
      newBread.Price = 5;
      Assert.AreEqual(5, newBread.Price);
    }

    [TestMethod]
    public void BreadConstructor_SetsPriceOfBreadTo5UsingOverloadedBreadConstructor_5()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(5, newBread.Price);
    }

    [TestMethod]
    public void BreadDiscounter_ReturnsAPriceForAListofBreadsWithOneElement_5()
    {
      List<Bread> loaves = new List<Bread>{ new Bread(5) };
      Assert.AreEqual(5, loaves[0].Price);
    }

    [TestMethod]
    public void BreadDiscounter_ReturnsAPriceForAListofBreadsWithTenElements_35()
    {
      List<Bread> loaves = new List<Bread>{ new Bread(5), new Bread(5), new Bread(5), new Bread(5), new Bread(5), new Bread(5), new Bread(5), new Bread(5), new Bread(5), new Bread(5) };
      Assert.AreEqual(5, Bread.BreadDiscounter(loaves));
    }

    


    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
      // any necessary logic to prep for test; instantiating new classes, etc.
      //Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}