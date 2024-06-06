using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._4._1
{
    public partial class MainForm : Form
    {
        private List<Coffee> coffeeOrders;

        public MainForm()
        {
            InitializeComponent();


            coffeeOrders = new List<Coffee> {
                new Coffee {OrderNumber = 1, Size = BeverageSize.Small, Temp = BeverageTemp.Cold, CoffeeType = CoffeeType.ColdBrew },
                new Coffee {OrderNumber = 2, Size = BeverageSize.Medium, Temp = BeverageTemp.Warm, CoffeeType = CoffeeType.Mocha },
                new Coffee {OrderNumber = 3, Size = BeverageSize.Large, Temp = BeverageTemp.Hot, CoffeeType = CoffeeType.Latte },
                new Coffee {OrderNumber = 4, Size = BeverageSize.XL, Temp = BeverageTemp.Iced, CoffeeType = CoffeeType.Americano },
                new Coffee {OrderNumber = 5, Size = BeverageSize.Small, Temp = BeverageTemp.Warm, CoffeeType = CoffeeType.Cappuccino },
            };

            // sets gridview data source to coffeeOrders
            dataGridViewCoffee.DataSource = coffeeOrders;

            RefreshDataGridView();

            

        }

        private void RefreshDataGridView()
        {
            // Refresh the DataGridView data source
            dataGridViewCoffee.DataSource = null;
            dataGridViewCoffee.DataSource = coffeeOrders;

            // Set the display order of the columns
            dataGridViewCoffee.Columns["OrderNumber"].DisplayIndex = 0;
            dataGridViewCoffee.Columns["Size"].DisplayIndex = 1;
            dataGridViewCoffee.Columns["Temp"].DisplayIndex = 2;
            dataGridViewCoffee.Columns["CoffeeType"].DisplayIndex = 3;

            // Make columns fill the entire DataGridView
            dataGridViewCoffee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public int GetNextOrderNumber()
        {
            return coffeeOrders.Count == 0 ? 1 : coffeeOrders.Max(o => o.OrderNumber) + 1;
        }

        public void AddOrder(Coffee order)
        {
            coffeeOrders.Add(order);
            dataGridViewCoffee.DataSource = null; // Refresh the DataGridView
            dataGridViewCoffee.DataSource = coffeeOrders;
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(this);
            addOrderForm.Show();
            this.Hide();
        }

        private void buttonFufillOrder_Click(object sender, EventArgs e)
        {
            if (coffeeOrders.Count > 0)
            {
                coffeeOrders.RemoveAt(dataGridViewCoffee.CurrentRow.Index);
                RefreshDataGridView();
                MessageBox.Show("Order fulfilled successfully!");
            }
            else
            {
                MessageBox.Show("No orders to fulfill!");
            }
        }
    }
}