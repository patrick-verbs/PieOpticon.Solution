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

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      // Arrange
      string inputDescription = "Second-stalest second-hand baked goods in the state's second-most-populated city!";
      Vendor testVendor = new Vendor("untested name", inputDescription);
      // Act
      string outputDescription = testVendor.Description;
      // Assert
      Assert.AreEqual(inputDescription, outputDescription);
    }
  }
}