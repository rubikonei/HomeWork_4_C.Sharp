using System;
using System.Reflection;

namespace ColorPrint
{
    class Print
    {
        public void ColorPrint(object obj)
        {
            PropertyInfo[] pi = obj.GetType().GetProperties();
            foreach(PropertyInfo p in pi)
            {
                try
                {
                    Attribute a = p.GetCustomAttribute(typeof(ColorAttribute));
                    Console.ForegroundColor = ((ColorAttribute)a).Color;
                }
                catch (NullReferenceException) { }
                Console.WriteLine(p.GetValue(obj));
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
