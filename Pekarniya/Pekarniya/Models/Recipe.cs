using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekarniya
{
    class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set;} 
        
        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
        }
        public void AddIngredient(string name, int quantity, string unit)
        {
            Ingredients.Add(new Ingredient(name, quantity, unit));
        }
    }
}
