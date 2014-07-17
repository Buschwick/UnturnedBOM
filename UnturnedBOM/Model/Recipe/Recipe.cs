using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UnturnedBOM.Model.Recipe
{
    public class Recipe
    {
        [XmlElement("Ingredient")]
        public Ingredient[] Ingredients { get; set; }

        [XmlElement("Result")]
        public Result Result { get; set; }
    }
}
