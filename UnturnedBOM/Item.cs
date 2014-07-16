using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnturnedBOM
{
    public class Item
    {
        public string Name { get; set; }
        public bool IsIngredient { get; set; }
        public bool IsResult { get; set; }
    }
}
