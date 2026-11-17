using CrmBL;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBlTest
{
    [TestClass]
    public sealed class CartTest
    {
        [TestMethod()]
     public void CartTester()
        {
            //arrange
            Customer customer = new Customer()
            {
                Name = "Peter",
                Id=1
            };
            Product product = new Product
            {
                Name = "Milk",
                Price = 100,
                Count = 2,
                Id=1

            };
            Product product2 = new Product
            {
                Name = "Sugar",
                Price = 100,
                Count = 3,
                Id=2

            };
            var cart = new Cart(customer);
           

            var expectedResult=new List<Product>()
            {
                product, product,product2
            };

            //act
            cart.Add(product);
            cart.Add(product);
            cart.Add(product2);
            var cartResult = cart.GetAll();
            
            //assert
            Assert.AreEqual(expectedResult.Count, cartResult.Count);
            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);

            }
        }
    }
}
