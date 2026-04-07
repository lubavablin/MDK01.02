using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BekeryClass.Models
{
    public class Pie
    {
        public string Name { get; set; }
        public Dictionary<string, int> Recipe { get; set; }

        public Pie()
        {
            Recipe = new Dictionary<string, int>();
        }
    }
}
