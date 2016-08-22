using System;

namespace ColorPrint
{
    class User
    {
        public User(string name, string login, int age)
        {
            Name = name;
            Login = login;
            Age = age;
        }

        [Color(ConsoleColor.Green)]
        public string Name { get; set; }

        
        public string Login { get; set; }

        [Color(ConsoleColor.Red)]
        public int Age { get; set; }
    }
}
