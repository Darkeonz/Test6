using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test6Mario.Entity;

namespace Test6Mario.Factory
{
    public class OrderFactory
    {
        Order order = new Order();

        public void AddPizza(Pizza pizza)
        {
            order.PizzaList.Add(pizza);     
        }

        public int GetNumberOfPizzas()
        {
            return order.PizzaList.Count();
        }

        public void RemovePizza(Pizza pizza)
        {
            for (int i = 0; i < order.PizzaList.Count(); i++)
            {
                if (order.PizzaList[i].Id == pizza.Id)
                {                   
                    order.PizzaList.Remove(pizza);
                }
            }
        }

    }
}