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
    public partial class EditInventory : Form
    {
        public EditInventory(Items item)
        {
            InitializeComponent();

            this.textBox3.Text = item.Stock.ToString();

        }

        private void EditBooks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int stock = Int32.Parse(textBox3.Text);
    

            Items item = new Items(stock);

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.restockItem(item);
        }
    }
}
