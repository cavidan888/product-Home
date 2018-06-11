using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yourself.Model;

namespace yourself.Controller
{
    class PrdouctController
    {
        public static void Create(string _name , int _price , string _catName , DateTime dateTime)
        {
            var product = new Product();
            product.Id = Entity.rand.Next(1,130);
            product.Name = _name;
            product.Price = _price;
            product.time = dateTime;
            product.CategoryName = _catName;
            Entity.products.Add(product);
        }

        public static List<Product> Read()
        {
            return Entity.products;
        }
    }
}
