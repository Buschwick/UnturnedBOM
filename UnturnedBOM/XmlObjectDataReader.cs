using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Resources;
using System.Xml;

namespace UnturnedBOM
{
    public class XmlObjectDataReader
    {
        public static IList<T> Read<T>(string filename) where T : new()
        {
            IList<T> data = new List<T>();

            try
            {
                StreamResourceInfo sri = Application.GetResourceStream(new Uri(filename, UriKind.RelativeOrAbsolute));
                using (XmlReader reader = XmlReader.Create(sri.Stream))
                {
                    Type objType = typeof(T);
                    string objName = objType.Name;

                    if (reader.ReadToFollowing(objName + "s"))
                    {
                        while (reader.ReadToFollowing(objName))
                        {
                            T obj = new T();

                            if (reader.HasAttributes)
                            {
                                reader.MoveToFirstAttribute();
                                do
                                {
                                    PropertyInfo property = objType.GetProperty(reader.Name);

                                    if (property != null && property.PropertyType == typeof(string))
                                    {
                                        property.SetValue(obj, reader.Value, null);
                                    }
                                }
                                while (reader.MoveToNextAttribute());
                            }

                            data.Add(obj);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Unable to parse XML file: {0}{1}", Environment.NewLine, e.Message));
            }

            return data;
        }
    }
}
