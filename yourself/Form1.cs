using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yourself.Model;
using yourself.Controller;

namespace yourself
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var name = prodcutName.Text;
            var price = int.Parse(ProductPrice.Text);
            var cateName = CategorySelecter.SelectedItem.ToString();
            var date = dateTimePicker1.Value;

            PrdouctController.Create(name,price,cateName,date);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ProductsListView.Text = string.Empty;

            foreach (var product in PrdouctController.Read())
            {
                ProductsListView.Text += product.Id + " . " + product.Name + " / " + product.CategoryName + " / " + product.Price + " / " + product.time.ToShortDateString() +  "\r\n";
            }
        }
    
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            var catName = AddCategoryBox.Text;
            var cat = new Category();
            cat.Name = catName;
            Entity.categories.Add(cat);
            CategorySelecter.Items.Clear();
            categoryTwo.Items.Clear();

            foreach (var proCat in CategoryController.Read()) 
            {
                CategorySelecter.Items.Add(proCat.Name);
                categoryTwo.Items.Add(proCat.Name);
            }
        }

        private void ShowCatProdcut_Click(object sender, EventArgs e)
        {
            

            foreach (var item in Entity.products)
            {
                if (item.CategoryName == categoryTwo.SelectedItem.ToString())
                {
                    
                    ProductsListView.Text += item.Name;
                    
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            foreach (var item in Entity.products)
            {
                if (item.Name.Contains(Search.Text))
                {
                    searchBox.Text += item.Id + " . " + item.Name + " . " + item.Price + " . " + item.time.ToShortDateString() + "\r\n";
                }

                if (item.Id.ToString() == Search.Text)
                {
                    searchBox.Text += item.Id + " / " + item.Name + "\r\n";
                }
            }
        }

        private void orderAlphabetic_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < Entity.products.Count; i++)
            {
                for (int c = 0; c < Entity.products.Count; c++)
                {
                    if (Entity.products[i].Name.CompareTo(Entity.products[c].Name) < 0)
                    {
                        Product myProd = Entity.products[i];
                        Entity.products[i] = Entity.products[c];
                        Entity.products[c] = myProd;
                    }
                }
            }

            alphabetic.Text = "";

            foreach (var item in Entity.products)
            {
                alphabetic.Text += item.Id + " . " + item.Name + " / " + item.CategoryName + " / " + item.Price + " " + item.time.ToString() + "\r\n";
            }


        }
    }
}
