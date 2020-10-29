using System;
using Figgle;
using JosephWare.commands;
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

            Authorization.Login(username, password);
        }

        public static void Joseph()
        {
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Blue;
            Write("JConsole> ");
            string command = ReadLine()?.ToLower();
            switch (command)
            {
                case "help":
                    Help.Execute();
                    break;
                case "exit":
                    WriteLine("Case 2");
                    break;
                default:
                    WriteLine("Command not found!");
                    break;
            }
            Joseph();
        }
    }
}
