using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UnturnedBOM.Model
{
    public class Recipe
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Tool")]
        public string Tool { get; set; }

        [XmlAttribute("CraftLvl")]
        public int CraftLvl { get; set; }

        [XmlElement("Ingredient")]
        public Ingredient[] Ingredients { get; set; }

        [XmlElement("Result")]
        public Result Result { get; set; }

        public Recipe()
        {
            Tool = "None";
            CraftLvl = 0;
        }
    }
}
