using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Milestone_4

{
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        //add file, user types itm info to add to list
        private void button1_Click(object sender, EventArgs e)
        {
          
            string productsName = textBox1.Text; //user adds products name
            double productPrice = double.Parse(textBox2.Text); //user adds product price
            int stock = Int32.Parse(textBox3.Text); //user adds amount of stock 
            double productNumber = double.Parse(textBox4.Text); //user adds product number also known as an ID number 

            Items item = new Items(productsName, productPrice, stock, productNumber);

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.addItem(item);  //calls and sends onto from1 

        }
    }
}
