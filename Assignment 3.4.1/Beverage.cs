using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._4._1
{
    public enum BeverageSize
    {
        Small,
        Medium,
        Large,
        XL
    }

    public enum BeverageTemp
    {
        Iced,
        Cold,
        Warm,
        Hot
    }

    public class Beverage
    {
        public int OrderNumber { get; set; }
        public BeverageSize Size { get; set; }
        public BeverageTemp Temp { get; set; }


    }
}
