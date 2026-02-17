using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekarniya
{
    public class BakeryShop
    {
        public Dictionary<string, int> AvailableIngredients { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public BakeryShop()
        {
            /// Запасы ингредиентов

            static var supplies = new Dictionary<string, int>
            {

                {"Мука", 500},
                {"Капуста", 200},
                {"масло", 100},
                {"Яйцо", 3},
                {"Картошка", 300},
                {"Лук", 0},
                {"Яблоко", 250},
                {"Сахар", 100},
                {"Корица", 100},

            };
            /// Рецепты
            static var recipes = new Dictionary<string, Dictionary<string, int>>
            {
            {
                "Пирожок с поваром", new Dictionary<string, int>
                {
                    {"Мука", 200 },
                    {"Мясо повара", 200 }
                }
            }
            };
        } 
    }
}
