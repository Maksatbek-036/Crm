using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBlTest
{


[TestClass]
public class CashDeskTests
{
    [TestMethod]
    public void CashDeskTest()
    {
        //arrange
        var customer1 = new Customer
        {
            Name = "TesterUser",
            Id = 1
        };
        var customer2 = new Customer
        {
            Name = "TesterUser2",
            Id = 2
        };
        var seller = new Seller
        {
            Id = 1,
            Name = "SellerName",

        };
        var product1 = new Product
        {
            Id = 1,
            Name = "Milk",
            Price = 150,
            Count = 5
        };
        var product2 = new Product
        {
            Id = 2,
            Name = "Bread",
            Price = 100,
            Count = 10
        };
        var cart1 = new Cart(customer1);
        cart1.Add(product1);
        cart1.Add(product1);
        cart1.Add(product2);
        var cart2 = new Cart(customer2);
        cart2.Add(product1);
        cart2.Add(product2);
        cart2.Add(product2);

            var cashDesk = new CashDesk(1, seller)
            {
                MaxQueueLenght = 1
            };
        cashDesk.Enqueue(cart1);
        cashDesk.Enqueue(cart2);

        var cart1ExpectedResult = 400;
        var cart2ExpectedResult = 350;
        //act
        var cart1ActualResult = cashDesk.Dequeu();
        var cart2ActualResult = cashDesk.Dequeu();
        //assert
        Assert.AreEqual(cart1ExpectedResult, cart1ActualResult);
        Assert.AreEqual(cart2ExpectedResult, cart2ActualResult);
        Assert.AreEqual(2, product1.Count);
        Assert.AreEqual(7, product2.Count);
    }
}
}

