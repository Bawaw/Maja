using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maja
{

    static class Program
    {
        public static bool menu = true;
        static void Main(string[] args)
        {
            string command;
            do
            {
                Console.WriteLine("What do you want to do?:");
                Console.WriteLine("---- -- --- ---- -- ---:");
                Console.WriteLine("Ls [name]");
                Console.WriteLine("Sphere [name]");
                Console.WriteLine("Light [name]");
                Console.WriteLine("Parent <ParentName> <ChildName>");
                Console.WriteLine("Unparent [node]");
                Console.WriteLine("Rename <OldName> <NewName>");
                Console.WriteLine("Delete <name>");
                Console.WriteLine("Clear");
                Console.WriteLine("Exit");
                Console.WriteLine();
                Console.Write(':');
                command = Console.ReadLine();
                Commander.checkCommand(command);
            }
            while (menu == true);
          

          
            Console.ReadLine();
        }
    }
}
