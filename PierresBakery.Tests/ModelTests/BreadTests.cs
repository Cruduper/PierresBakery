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
      Bread newBread= new Bread();
      Assert.AreEqual(typeof(int), newBread.GetType());
    }
  }
}