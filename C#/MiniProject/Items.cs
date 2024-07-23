using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    internal class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Soup : Items { }
    class Starter : Items { }
    class MainCourse : Items{ }
    class Dessert : Items { }
    class Cart : Items { }

}
