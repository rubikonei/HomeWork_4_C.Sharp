using System;

namespace ColorPrint
{
    class House
    {
        public House(int floors, int doors, int windows)
        {
            Floors = floors;
            Doors = doors;
            Windows = windows;
        }


        public int Floors { get; set; }

        [Color(ConsoleColor.Blue)]
        public int Doors { get; set; }

        [Color(ConsoleColor.Yellow)]
        public int Windows { get; set; }
    }
}
