using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PieOpticon.Models;

namespace PieOpticon.Test
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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
      string inputName = "Second-Rate Baked Goods";
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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      // Arrange
      List<Vendor> testList = new List<Vendor> {};
      // Act
      List<Vendor> result = Vendor.GetAll();
      // Assert
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      // Arrange
      string inputName = "Second-Rate Baked Goods";
      string inputDescription = "Second-stalest second-hand baked goods in the state's second-most-populated city!";
      Vendor testVendor = new Vendor(inputName, inputDescription);
      List<Vendor> expectedList = new List<Vendor>
      {
        testVendor
      };
      // Act
      List<Vendor> outputList = Vendor.GetAll();
      // Assert
      CollectionAssert.AreEqual(expectedList, outputList);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
    // Arrange
    string inputName = "Twice-Baked Goods";
    string inputDescription = "Our supplier bakes them! We bake them again! You get them TWICE as fresh!";
    Vendor testVendor = new Vendor(inputName, inputDescription);
    // Act
    int outputId = testVendor.Id;
    // Assert
    Assert.AreEqual(1, outputId);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
    // Arrange
    string inputName1 = "Second-Rate Baked Goods";
    string inputDescription1 = "Second-stalest second-hand baked goods in the state's second-most-populated city!";
    string inputName2 = "Twice-Baked Goods";
    string inputDescription2 = "Our supplier bakes them! We bake them again! You get them TWICE as fresh!";
    Vendor testVendor1 = new Vendor(inputName1, inputDescription1);
    Vendor testVendor2 = new Vendor(inputName2, inputDescription2);
    // Act
    Vendor foundVendor = Vendor.Find(2);
    // Assert
    Assert.AreEqual(testVendor2, foundVendor);
    }
  }
}