using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JosephWare
{
    class Authorization
    {
        static public void Login(string username, string password)
        {
            if (username == "joseph")
            {
                if (password == "joseph")
                {
                    WriteLine("Logged in successfully!");
                    Program.Joseph();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password invalid");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Username not found!");
                Console.ReadKey();
            }
        }
    }
}
