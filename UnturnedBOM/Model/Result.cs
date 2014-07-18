using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UnturnedBOM.Model
{
    public class Result
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Count")]
        public int Count { get; set; }
    }
}
