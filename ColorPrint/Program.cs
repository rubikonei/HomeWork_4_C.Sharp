using System;

namespace ColorPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Andrei", "login", 29);
            House house = new House(2, 8, 12);
            Print print = new Print();

            Console.WriteLine("Свойства объекта " + user.GetType().Name + ":");
            print.ColorPrint(user);

            Console.WriteLine();

            Console.WriteLine("Свойства объекта " + house.GetType().Name + ":");
            print.ColorPrint(house);


        }
    }
}
