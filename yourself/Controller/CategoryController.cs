using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourself.Model;

namespace yourself.Controller
{
    class CategoryController
    {
        public void Create(string _name)
        {
            var cat = new Category();
            cat.Name = _name;
            Entity.categories.Add(cat);
        }

        public static List<Category> Read()
        {
            return Entity.categories;
        }
    }
}
