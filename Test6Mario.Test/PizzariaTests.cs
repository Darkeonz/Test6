using System;
using System.Linq;
using Xunit;
using Test6Mario.Entity;
using System.Collections.Generic;

namespace Test6Mario.Test
{
    public class PizzariaTests
    {
        Pizza pizza = new Pizza() {Id = 1, Price = 32, Name = "Pepperoni Special"  };
        Pizza pizza1 = new Pizza() { Id = 2, Price = 12, Name = "Super Pizza" };
        Pizza pizza2 = new Pizza() { Id = 3, Price = 50, Name = "Brians Pizza" };
        Order pizzaOrder = new Order() { Id = 1, Price = 0, OrderTime = 0, PizzaList = new List<Pizza>()};
        Order pizzaOrder2 = new Order() { Id = 2, Price = 0, OrderTime = 0, PizzaList = new List<Pizza>() };
        


        [Fact]
         public void TestGetPrice()
        {
            Pizza instance = pizza;

            int expResult = 32; 
            Assert.Equal(expResult, instance.Price);
        }

        [Fact]
        public void TestSetPrice()
        {
            Pizza instance = pizza1;
            int price = 200;
            instance.Price = price;
       
            Assert.Equal(price, instance.Price);
        }


        [Fact]
        public void TestAddPizza()
        {
            Pizza instanceOfPizza = pizza2;
            Order instanceOfOrder = pizzaOrder2;
            instanceOfOrder.PizzaList.Add(instanceOfPizza);
            Assert.Contains(pizza2, instanceOfOrder.PizzaList);
        }

        [Fact]
        public void TestRemovePizza()
        {
            Pizza instanceOfPizza = pizza2;
            Order instanceOfOrder = pizzaOrder2;
            instanceOfOrder.PizzaList.Add(instanceOfPizza);
            Assert.Contains(pizza2, instanceOfOrder.PizzaList);
        }



    }
}
