using System;
using System.Net.Mime;
using System.Windows.Forms;
using Figgle;
using JosephWare.gui;
using static System.Console;
using Help = JosephWare.commands.Help;

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
                    WriteLine(@"Exiting");
                    Environment.Exit(0);
                    break;
                case "about":
                    if (Environment.UserInteractive)
                    {
                        // A console is opened
                        var aboutBox = new AboutBox();
                        aboutBox.Show();
                    }
                    break;
                default:
                    WriteLine(@"Command not found!");
                    break;
            }
            Joseph();
        }
    }
}
