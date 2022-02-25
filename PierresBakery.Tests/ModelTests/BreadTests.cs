using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;


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
      Assert.AreEqual(6, newBread.Price);
    }

    // public void BreadConstructor_SetsPriceOfBreadTo5UsingOverloadedBreadConstructor_5()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Bread newBread = new Bread(5);
    //   Assert.AreEqual(6, newBread.Price);
    // }



    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
      // any necessary logic to prep for test; instantiating new classes, etc.
      //Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}