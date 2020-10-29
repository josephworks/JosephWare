using System;
using System.Threading;
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

            // Check if ESC is pressed while attempting to log in

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press ESC to continue as guest");
            ResetColor();

            do
            {
                while (!Console.KeyAvailable)
                {
                    Write("Username: ");
                    string username = ReadLine();
                    Write("Password: ");
                    string password = ReadLine();

                    Authorization.Login(username, password);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            // Continue as guest if ESC is pressed
            WriteLine("Wheel just test it out");
            Console.WriteLine("Wheel just test it out");
        }

        static public void Joseph()
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
