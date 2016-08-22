using System;

namespace ColorPrint
{
    [AttributeUsage(AttributeTargets.Property)]
    class ColorAttribute : Attribute
    {
        public ConsoleColor Color { get; set; }

        public ColorAttribute(ConsoleColor color)
        {
            Color = color;
        }
    }
}
