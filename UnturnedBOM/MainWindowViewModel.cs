using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Resources;
using System.Xml.Serialization;
using UnturnedBOM.Model.Item;
using UnturnedBOM.Model.Recipe;

namespace UnturnedBOM
{
    public class MainWindowViewModel
    {
        private readonly ItemData ItemCollection;
        private readonly RecipeData RecipeCollection;

        private T LoadData<T>(string xmlPath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));

            StreamResourceInfo sri = Application.GetResourceStream(new Uri(xmlPath, UriKind.RelativeOrAbsolute));

            T XmlData;

            using (TextReader reader = new StreamReader(sri.Stream))
            {
                object obj = deserializer.Deserialize(reader);
                XmlData = (T)obj;
            }

            return XmlData;
        }

        public MainWindowViewModel()
        {
            ItemCollection = LoadData<ItemData>(@"/Data/items.xml");
            //RecipeCollection = LoadData<RecipeData>(@"/Data/recipes.xml");
        }
    }
}
