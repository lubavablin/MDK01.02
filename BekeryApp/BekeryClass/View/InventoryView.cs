using BekeryClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BekeryClass.View
{
    public class InventoryView
    {
        private readonly List<Ingredient> _ingredients;

        public InventoryView(List<Ingredient> ingredients)
        {
            _ingredients = ingredients;
        }

        public bool CanMake(Pie pie)
        {
            return pie.Recipe.All(r =>
                _ingredients.Any(i => i.Name == r.Key && i.Quantity >= r.Value));
        }
    }
}
