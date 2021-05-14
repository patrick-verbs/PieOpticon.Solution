using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PieOpticon.Models;

namespace PieOpticon.Test
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderCtor_CreatesInstanceOf_Order()
    {
      // Arrange
      Vendor testVendor = new Vendor(
        "Second-Rate Baked Goods",
        "Second-stalest second-hand baked goods in the state's second-most-populated city!"
      );
      string orderTitle = "Bread x 48; Pastry x 24";
      string date = "2021-05-14";
      int vendorId = testVendor.Id;
      int price = 180;// == (48 * 3) + (24 * 1.5)
      // Act
      Order testOrder = new Order(orderTitle, date, vendorId, price);
      // Assert
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetAndConcatTitleDateVendorIdPrice_ReturnsStringStringIntInt_String()
    {
      // Arrange
      Vendor testVendor = new Vendor(
        "Second-Rate Baked Goods",
        "Second-stalest second-hand baked goods in the state's second-most-populated city!"
      );
      string orderTitle = "Bread x 48; Pastry x 24";
      string date = "2021-05-14";
      int vendorId = testVendor.Id;
      int price = 180;// == (48 * 3) + (24 * 1.5)
      string expectedString = "Bread x 48; Pastry x 24 | 2021-05-14 | Second-Rate Baked Goods | $180";
      // Act
      Order testOrder = new Order(orderTitle, date, vendorId, price);
      string returnedString = $"{orderTitle} | {date} | {Vendor.Find(vendorId).Name} | ${price}";
      // Assert
      Assert.AreEqual(expectedString, returnedString);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> testList = new List<Order> {};
      // Act
      List<Order> result = Order.GetAll();
      // Assert
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      // Arrange
      Vendor testVendor = new Vendor(
        "Test vendor",
        "Description for a test vendor"
      );
      string orderTitle = "Bread x 48; Pastry x 24";
      string date = "2021-05-14";
      int vendorId = testVendor.Id;
      int price = 180;
      Order testOrder = new Order(orderTitle, date, vendorId, price);
      List<Order> expectedList = new List<Order>
      {
        testOrder
      };
      // Act
      List<Order> outputList = Order.GetAll();
      // Assert
      CollectionAssert.AreEqual(expectedList, outputList);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
    // Arrange
      Vendor testVendor1 = new Vendor(
        "1st test vendor",
        "Description for a test vendor"
      );
      Vendor testVendor2 = new Vendor(
        "2nd test vendor",
        "Description for a test vendor"
      );
    Order testOrder1 = new Order("1st order title", "2021-05-14", testVendor1.Id, 90);
    Order testOrder2 = new Order("2nd order title", "2021-05-14", testVendor2.Id, 180);
    // Act
    Order foundOrder = Order.Find(2);
    // Assert
    Assert.AreEqual(testOrder2, foundOrder);
    }

    [TestMethod]
    public void OrderCtor_AddsOrderToVendorList_Order()
    {
      // Arrange
      Vendor testVendor = new Vendor(
        "Test vendor",
        "Description for a test vendor"
      );
      string orderTitle = "Bread x 48; Pastry x 24";
      string date = "2021-05-14";
      int vendorId = testVendor.Id;
      int price = 180;
      // Act
      Order constructedOrder = new Order(orderTitle, date, vendorId, price);
      Order returnedVendorOrder = Vendor.Find(vendorId).Orders[0];
      // Assert
      Assert.AreEqual(constructedOrder, returnedVendorOrder);
    }
  }
}