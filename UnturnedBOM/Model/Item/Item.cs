using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UnturnedBOM.Model.Item
{
    public class Item
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("IsIngredient")]
        public bool IsIngredient { get; set; }

        [XmlAttribute("IsResult")]
        public bool IsResult { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
