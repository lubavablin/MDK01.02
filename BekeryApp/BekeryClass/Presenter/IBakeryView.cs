using BekeryClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BekeryClass.Presenter
{
    public interface IBakeryView
    {
        string SelectedPie { get; }
        void ShowMessage(string message);
        void ShowAlternatives(List<string> pies);
    }
}
