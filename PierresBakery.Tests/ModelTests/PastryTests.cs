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
      Assert.AreEqual(typeof(int), newPastry.GetType());
    }


    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
      // any necessary logic to prep for test; instantiating new classes, etc.
      //Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }

}