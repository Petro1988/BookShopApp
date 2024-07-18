using BookShopApp.Controllers;
using BookShopApp.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopApp.Tests
{
    public class OrderControllerTests
    {
        [Fact]
        public void CannotChecoutEmptyCart()
        {
            //Arrange - create a mock repository
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            //Arrange - create an empty cart
            Cart cart = new Cart();
            //Arrange - create the order
            Order order = new Order();
            //Arrange - create an instence of the controller
            OrderController target = new OrderController(mock.Object, cart);

            //Act
            ViewResult? result = target.Checkout(order) as ViewResult;

            //Assert - check that the order hasn't been stored
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Never);
            //Assert - check that the method is returning the default view
            Assert.True(string.IsNullOrEmpty(result?.ViewName));
            //Asser - check I am passing an invalid model to the view
            Assert.False(result?.ViewData.ModelState.IsValid);
        }

        [Fact]
        public void CannotCheckoutInvalidShippingDetails()
        {
            //Arrange - create a mock order repository
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            //Arrange - create a cart with one item 
            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);
            //Arrange - create an instance of the controller
            OrderController target = new OrderController(mock.Object, cart);
            //Arrange - add an error to the model
            target.ModelState.AddModelError("error", "error");
            
            //Act - try to checkout
            ViewResult? result = target.Checkout(new Order()) as ViewResult;

            //Assert - check that the order hasn't been passed stored
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Never());
            //Assert - check that the method is returning the default view
            Assert.True(string.IsNullOrEmpty(result?.ViewName));
            //Assert - check that I am passing an invalid model to the view
            Assert.False(result?.ViewData.ModelState.IsValid);
        }

        [Fact]
        public void CanCheckoutAndSubmitOrder()
        {
            //Arrange - create a mock order repository
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            //Arrange - create a cart with one item
            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);
            //Arrange - create an instance of the controller
            OrderController target = new OrderController(mock.Object, cart);

            //Act - try to checkout
            RedirectToPageResult? result = target.Checkout(new Order()) as RedirectToPageResult;

            //Assert - check that the order has been stored
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Once);
            //Assert - check the method is redirecting to the Completed action 
            Assert.Equal("/Completed", result?.PageName);
        }
    }
}
