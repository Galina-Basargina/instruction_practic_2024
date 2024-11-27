using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_2._1.Classes
{
    internal class Composition
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Weight { get; set; }
        public Composition(int id_Dish, string pruductName, int weight)
        {
            Id = id_Dish;
            ProductName = pruductName;
            Weight = weight;
        }
    }
}
