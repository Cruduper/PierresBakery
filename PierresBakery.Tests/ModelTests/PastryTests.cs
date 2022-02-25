using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfItemPastry_PastryInstance()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryDotSetPrice_SetsPriceOfPastryTo5_5()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Pastry newPastry = new Pastry();
      newPastry.Price = 5;
      Assert.AreEqual(5, newPastry.Price);
    }

    [TestMethod]
    public void PastryConstructor_SetsPriceOfPastryTo2UsingOverloadedPastryConstructor_2()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(2, newPastry.Price);
    }

    [TestMethod]
    public void PastryDiscounter_ReturnsAPriceForAListofPastrysWithOneElement_2()
    {
      List<Pastry> pastes = new List<Pastry>{ new Pastry(2) };
      Assert.AreEqual(3, pastes[0].Price);
    }
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
      // any necessary logic to prep for test; instantiating new classes, etc.
      //Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }

}