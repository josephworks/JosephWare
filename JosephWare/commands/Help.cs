using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephWare.commands
{
    class Help
    {
        static public void Execute()
        {
            Console.WriteLine(@"
            -=- JosephWare Help -=-
            Help - Shows this menu
            Exit - Closes this application
            ");
        }
    }
}
