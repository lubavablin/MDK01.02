using BekeryClass.Models;
using BekeryClass.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BekeryClass.Presenter
{
    public class BakeryPresenter
    {
        private readonly IBakeryView _view;
        private readonly InventoryView _inventory;
        private readonly RecommendationView _recommendation;
        private readonly List<Pie> _pies;

        public BakeryPresenter(IBakeryView view,
            InventoryView inventory,
            RecommendationView recommendation,
            List<Pie> pies)
        {
            _view = view;
            _inventory = inventory;
            _recommendation = recommendation;
            _pies = pies;
        }

        public void OnOrder()
        {
            var pie = _pies.First(p => p.Name == _view.SelectedPie);

            if (_inventory.CanMake(pie))
            {
                _view.ShowMessage("Заказ принят!");
            }
            else
            {
                var alternatives = _recommendation
                    .GetAvailableAlternatives(pie, _pies)
                    .Select(p => p.Name)
                    .ToList();

                _view.ShowMessage("Нет ингредиентов");
                _view.ShowAlternatives(alternatives);
            }
        }
    }
}
