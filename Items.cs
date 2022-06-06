using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Milestone_4

{
    public class Items
    {
        //getting products name
        private string productsName;
        public string ProductName
        {
            get { return productsName; }
            set { productsName = value; }
        }

        // getting product price
        private double productPrice;
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        //getting amount in stock
        private int stock;
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        //getting product number
        private double ProductNumber;
        public double productNumber
        {
            get { return ProductNumber; }
            set { ProductNumber = value; }
        }

        public Items(string productsName, double productPrice, int stock, double ProductNumber)
        {
            this.ProductName = productsName;
            this.ProductPrice = productPrice;
            this.Stock = stock;
            this.productNumber = ProductNumber;
        }

        public Items(int stock)
        {
            this.stock = stock;
        }


        //Editing any item 
        public void changeproductName(string newName)
        {
            ProductName = productsName;
        }
        public void changeproductPrice(double newProductPrice)
        {
            ProductPrice = productPrice;
        }
        public void changeStock(int newStock)
        {
            Stock = stock;
        }

    }

    //checking for inventory
    public class Warehouse
    {
        public List<Items> Items = new List<Items>();

        //send user to add page to add another item
        public void addItems(Items item)
        {
            this.Items.Add(item);
        }



        //removes items 
        public void removeItems(int index)
        {
            this.Items.RemoveAt(index);
        }

        //allows user to restock 
        public void restockItem(Items items, int stock)
        {

            if (items.Stock == 0)
            {
                items.changeStock(stock);
            }

        }



        // find book by book name, and gerne
        public Items findProduct(string productName, int productNumber)
        {
            Items res = null;
            foreach (Items items in this.Items)
            {
                if (items.ProductName == productName && items.productNumber == productNumber)
                {
                    res = items; break;
                }

            }
            return res;
        }
    }
}
