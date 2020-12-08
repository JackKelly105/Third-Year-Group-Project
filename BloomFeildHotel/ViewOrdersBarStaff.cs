﻿using BloomFeildHotel.Properties;
using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloomFeildHotel
{
    public partial class ViewOrdersBarStaff : Form
    {
        private FormContainer fc;
        private IModel Model;
        public ViewOrdersBarStaff(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void lblAddDrink_Click(object sender, EventArgs e)
        {

        }

        private void ViewOrdersBarStaff_Load(object sender, EventArgs e)
        {
            Model.GetAllOrders();
            foreach (Orders order in Model.OrdersList)
            {

                listBox3.Items.Add(string.Format("{0} | €{1} , {2} | €{3}", order.Food, order.FoodPrice, order.Drink, order.DrinkPrice));

            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string selectedItemText;
            selectedItemText = listBox3.SelectedItem.ToString();
            listBox1.Items.Add(selectedItemText);
            // add the item to the ListBoxStuff settings 
            
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            formBarStaff form = new formBarStaff(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectedItemText;
            selectedItemText = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(selectedItemText);
        }
    }
}
