using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UnturnedBOM.Model
{
    public class ItemData
    {
        [XmlElement("Item")]
        public Item[] Items { get; set; }
    }
}
