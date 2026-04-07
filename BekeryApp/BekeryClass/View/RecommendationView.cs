using BekeryClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BekeryClass.View
{
    public class RecommendationView
    {
        private readonly InventoryView _inventory;

        public RecommendationView(InventoryView inventory)
        {
            _inventory = inventory;
        }

        public List<Pie> GetAvailableAlternatives(Pie requested, List<Pie> allPies)
        {
            return allPies
                .Where(p => p.Name != requested.Name && _inventory.CanMake(p))
                .ToList();
        }
    }
}
