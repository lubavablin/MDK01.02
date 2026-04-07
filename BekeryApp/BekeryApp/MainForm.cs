using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BekeryClass.Models;
using BekeryClass.Presenter;
using BekeryClass.View;

namespace BekeryApp
{
    public partial class MainForm: Form, IBakeryView
    {
        private BakeryPresenter _presenter;
        private List<Pie> _pies;
        public MainForm()
        {
            InitializeComponent();
            var ingredients = new List<Ingredient>
            {
                new Ingredient { Name = "Flour", Quantity = 10 },
                new Ingredient { Name = "Sugar", Quantity = 5 }
            };

            _pies = new List<Pie>
            {
                new Pie
                {
                    Name = "Яблочный",
                    Recipe = new Dictionary<string, int>
                    {
                        { "Flour", 2 },
                        { "Sugar", 1 }
                    }
                },
                new Pie
                {
                    Name = "Вишнёвый",
                    Recipe = new Dictionary<string, int>
                    {
                        { "Flour", 2 },
                        { "Sugar", 10 }
                    }
                }
            };

            var inventory = new InventoryView(ingredients);
            var recommendation = new RecommendationView(inventory);

            _presenter = new BakeryPresenter(this, inventory, recommendation, _pies);

            comboBoxPies.DataSource = _pies.Select(p => p.Name).ToList();
        }

        public string SelectedPie
        {
            get { return comboBoxPies.SelectedItem.ToString(); }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowAlternatives(List<string> pies)
        {
            MessageBox.Show("Попробуйте: " + string.Join(", ", pies));
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            _presenter.OnOrder();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
