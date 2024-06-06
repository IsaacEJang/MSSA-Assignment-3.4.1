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
    public partial class AddOrderForm : Form
    {
        private MainForm mainForm;

        public AddOrderForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;

            comboBoxSize.DataSource = Enum.GetValues(typeof(BeverageSize));
            comboBoxTemp.DataSource = Enum.GetValues(typeof(BeverageTemp));
            comboBoxCoffeeType.DataSource = Enum.GetValues(typeof(CoffeeType));

            RefreshForm();
        }

        private void RefreshForm()
        {
            comboBoxSize.SelectedIndex = -1; // Reset the combo box selection
            comboBoxTemp.SelectedIndex = -1; // Reset the combo box selection
            comboBoxCoffeeType.SelectedIndex = -1; // Reset the combo box selection
        }

        private void buttonSubmitOrder_Click(object sender, EventArgs e)
        {
            BeverageSize size = (BeverageSize)comboBoxSize.SelectedItem;
            BeverageTemp temp = (BeverageTemp)comboBoxTemp.SelectedItem;
            CoffeeType coffeeType = (CoffeeType)comboBoxCoffeeType.SelectedItem;

            Coffee newOrder = new Coffee
            {
                OrderNumber = mainForm.GetNextOrderNumber(),
                Size = size,
                Temp = temp,
                CoffeeType = coffeeType
            };

            mainForm.AddOrder(newOrder);
            MessageBox.Show("Order submitted successfully!");
            RefreshForm(); // Reset the form after submission

        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                mainForm.Show();
            }
        }
    }
}