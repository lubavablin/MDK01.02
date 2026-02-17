using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekarniya
{
    class Program
    {

        /// Запасы ингредиентов

        static Dictionary<string, int> supplies = new Dictionary<string, int>
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
        static Dictionary<string, Dictionary<string, int>> recipes = new Dictionary<string, Dictionary<string, int>>
        {
            {
                "Пирожок с поваром", new Dictionary<string, int>
                {
                    {"Мука", 200 },
                    {"Мясо повара", 200 }
                }
            }
        }
    }
}
