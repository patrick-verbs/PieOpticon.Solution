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
      string expectedString = $"{orderTitle} | ";
      // Act
      Order testOrder = new Order(orderTitle, date, vendorId, price);
      // Assert
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   // Arrange
    //   string inputDescription = "Second-stalest second-hand baked goods in the state's second-most-populated city!";
    //   Order testOrder = new Order("untested name", inputDescription);
    //   // Act
    //   string outputDescription = testOrder.Description;
    //   // Assert
    //   Assert.AreEqual(inputDescription, outputDescription);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_OrderList()
    // {
    //   // Arrange
    //   List<Order> testList = new List<Order> {};
    //   // Act
    //   List<Order> result = Order.GetAll();
    //   // Assert
    //   CollectionAssert.AreEqual(testList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsOrders_OrderList()
    // {
    //   // Arrange
    //   string inputName = "Second-Rate Baked Goods";
    //   string inputDescription = "Second-stalest second-hand baked goods in the state's second-most-populated city!";
    //   Order testOrder = new Order(inputName, inputDescription);
    //   List<Order> expectedList = new List<Order>
    //   {
    //     testOrder
    //   };
    //   // Act
    //   List<Order> outputList = Order.GetAll();
    //   // Assert
    //   CollectionAssert.AreEqual(expectedList, outputList);
    // }

    // [TestMethod]
    // public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    // {
    // // Arrange
    // string inputName = "Twice-Baked Goods";
    // string inputDescription = "Our supplier bakes them! We bake them again! You get them TWICE as fresh!";
    // Order testOrder = new Order(inputName, inputDescription);
    // // Act
    // int outputId = testOrder.Id;
    // // Assert
    // Assert.AreEqual(1, outputId);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectOrder_Order()
    // {
    // // Arrange
    // string inputName1 = "Second-Rate Baked Goods";
    // string inputDescription1 = "Second-stalest second-hand baked goods in the state's second-most-populated city!";
    // string inputName2 = "Twice-Baked Goods";
    // string inputDescription2 = "Our supplier bakes them! We bake them again! You get them TWICE as fresh!";
    // Order testOrder1 = new Order(inputName1, inputDescription1);
    // Order testOrder2 = new Order(inputName2, inputDescription2);
    // // Act
    // Order foundOrder = Order.Find(2);
    // // Assert
    // Assert.AreEqual(testOrder2, foundOrder);
    // }
  }
}