using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UnturnedBOM
{
    public static class DeepCopy
    {
        public static T Copy<T>(T obj) where T : new()
        {
            T copy = new T();

            foreach (var prop in typeof(T).GetProperties())
            {
                prop.SetValue(copy, prop.GetValue(obj, null), null);
            }

            return copy;
        }
    }
}
