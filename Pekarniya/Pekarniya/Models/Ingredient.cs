using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekarniya
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public Ingredient(string name, int quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
        public override string ToString()
        {
            return $"{Name}: {Quantity}: {Unit}";
        }
    }
}
