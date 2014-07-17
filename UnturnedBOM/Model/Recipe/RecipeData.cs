using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UnturnedBOM.Model.Recipe
{
    public class RecipeData
    {
        [XmlElement("Recipe")]
        public Recipe[] Recipes { get; set; }
    }
}
