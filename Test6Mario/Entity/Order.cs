using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test6Mario.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public List<Pizza> PizzaList { get; set; }
        public int Price { get; set; }
        public int OrderTime { get; set; }
    }
}