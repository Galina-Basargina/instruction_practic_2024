using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_2._1.Classes
{
    public class Dish
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public string Type { get; set; }
        public string Base { get; set; }
        public int Weight { get; set; }

        public Dish(int id, string dishName, string type, string bases, int weight)
        {
            Id = id;
            DishName = dishName;
            Type = type;
            Base = bases;
            Weight = weight;
        }
    }
}
