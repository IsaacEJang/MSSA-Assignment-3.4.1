using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._4._1
{
    public enum CoffeeType
    {
        Espresso,
        Americano,
        Latte,
        Cappuccino,
        Black,
        Mocha,
        ColdBrew

    }
    public class Coffee : Beverage
    {
        
        public CoffeeType CoffeeType { get; set; }


    }
}
