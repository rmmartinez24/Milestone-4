using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_4
{
    public partial class Form1 : Form
    {
        //products already in warehouse
        Warehouse ItemList = new Warehouse();
        Items first_product = new Items("iPhone", 999.99, 20, 1001);
        Items second_product = new Items("iPhone Pro", 1099.99, 50, 1002);
        Items third_product = new Items("iPad", 799.99, 37, 1003);
        Items fourth_product = new Items("iPad Pro", 1200.99, 37, 1004);
        Items fith_product = new Items("AirPods", 199.99, 50, 1005);
        Items sixth_product = new Items("AirPods", 249.99, 40, 1006);
        Items seventh_product = new Items("MacBook Pro", 2299.99, 24, 1007);
        Items eighth_product = new Items("MacBook Air", 1049.99, 70, 1008);

        public Form1()
        {
            //dispalying warehouse iteams first 
            InitializeComponent();
            ItemList.addItems(first_product);
            ItemList.addItems(second_product);
            ItemList.addItems(third_product);
            ItemList.addItems(fourth_product);
            ItemList.addItems(fith_product);
            ItemList.addItems(sixth_product);
            ItemList.addItems(seventh_product);
            ItemList.addItems(eighth_product);
            DisplayItem(ItemList);
        }

        public Form1(Items item)
        {
            InitializeComponent();
            ItemList.addItems(item);
            DisplayItem(ItemList);
        }


        //displaying inventory 
        public void DisplayItem(Warehouse List)
        {
            listBox1.Items.Clear();
            foreach (Items items in List.Items)
            {
                listBox1.Items.Add("Product Name: " + items.ProductName +  " , Product Price: $" + items.ProductPrice.ToString() + " , Amount in Stock: " + items.Stock.ToString() + " , Product Number: " + items.productNumber.ToString() + "\n");
                //listBox1.Items.Add(" ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddInventory frm2 = new AddInventory();
            frm2.ShowDialog();
        }


        //remove items
        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                ItemList.removeItems(listBox1.SelectedIndex);
                DisplayItem(ItemList);
            }
        }


        //restock product amount
        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                Items item = ItemList.Items[listBox1.SelectedIndex];
                int stock = Int32.Parse(Interaction.InputBox("Restock Amount: "));
                ItemList.restockItem(item, stock);
                DisplayItem(ItemList);

            }

        }


        //find product 
        private void button4_Click(object sender, EventArgs e)
        {
            string productName = Interaction.InputBox("Input Poducts Name: ");
            int productNumber = Int32.Parse(Interaction.InputBox("Enter Product Number: "));
            Items items = ItemList.findProduct(productName, productNumber);
            MessageBox.Show(items.ProductName + " , $" + items.ProductPrice.ToString() + " , " + items.Stock.ToString() + " , " + items.productNumber.ToString());
        }


        //add an item
        public void addItem(Items item)
        {
            ItemList.addItems(item);
            DisplayItem(ItemList);
        }


        //change an item
        public void restockItem(Items item)
        {
            ItemList.addItems(item);
            DisplayItem(ItemList);
        }
    }
}
