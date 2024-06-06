using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._4._1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            /*
             Create an abstract base class to represent “Beverage” and inherit “Coffee” class from it. 
            Create a list ( you may use List class) of coffees. Design windows form application to 
            display the list of coffees in grid and perform add/ delete.

            Keep some base properties in Beverage class which can be inherited in Coffee. 
            Inherited class can have more specific properties. Properties are customizable as needed.
             */


        }

        public static List<Coffee> coffeeList = new List<Coffee>();

    }
}
