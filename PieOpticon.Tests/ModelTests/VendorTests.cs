using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PieOpticon.Models;

namespace PieOpticon.Test
{
  [TestClass]
  public class VendorTests
  {
    //

    [TestMethod]
    public void VendorCtor_CreatesInstanceOf_Vendor()
    {
      Vendor testVendor = new Vendor("test", "this is a test vendor");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      // Arrange
      string inputName = "Sanji";
      Vendor testVendor = new Vendor(inputName, "untested description");
      // Act
      string outputName = testVendor.Name;
      // Assert
      Assert.AreEqual(inputName, outputName);
    }
  }
}