using System;
using Figgle;
using static System.Console;

namespace JosephWare
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(FiggleFonts.ThreePoint.Render("JosephWare"));
            Write("Username: ");
            string username = ReadLine();
            Write("Password: ");
            string password = ReadLine();

            Login(username, password);
        }

        public static void Joseph()
        {
            Console.Beep();
            WriteLine("Logged in successfully!");
            Write("JConsole> ");
            string command = ReadLine().ToLower();
            switch (command)
            {
                case "help":
                    WriteLine("Case 1");
                    break;
                case "exit":
                    WriteLine("Case 2");
                    break;
                default:
                    WriteLine("Command not found!");
                    break;
            }
        }

        public static void Login(string username, string password)
        {
            if (username == "joseph")
            {
                if (password == "joseph")
                {
                    BackgroundColor = ConsoleColor.Blue;
                    Joseph();
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Password invalid");
                    ReadKey();
                }
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Username not found!");
                ReadKey();
            }
        }
    }
}
