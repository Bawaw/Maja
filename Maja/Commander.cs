using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maja
{
    static class Commander
    {
        private static string name;

        static public void checkCommand(string Command)
        {
            string[] com = Command.Split(' ');
            switch (com[0])
            {
                case "Ls":
                {
                    Creator.List();
                }
                break;
                case "Clear":
                    Console.Clear();
                break;
                case "Sphere":
                {
                    if (com[1] != null)
                        name = NameProcessor.NewName(com[1]);
                    else
                        name = NameProcessor.NewName("Sphere");

                    Creator.CreateSphere(name);
                    com[1] = null;
                }
                break;
                case "Light":
                {
                    if (com[1] != null)
                        name = NameProcessor.NewName(com[1]);
                    else
                        name = NameProcessor.NewName("Light");

                    Creator.CreateLight(name);
                    com[1] = null;
                }
                break;
                case "Parent":
                {

                }
                break;
                case "Unparent":
                {

                }
                break;
                case "Rename":
                {
                    if (com[1] != null && com[2] != null)
                    {
                        Creator.Rename(com[1],com[2]);
                    }
                    com[1] = null;
                    com[2] = null;
                 }
                break;
                case "Delete":
                {
                    if (com[1] != null)
                    {
                        Creator.Delete(com[1]);
                    }
                    com[1] = null;
                }
                break;
                case "exit":
                Program.menu = false;
                break;
                
                default:
                Console.WriteLine("Command not recognized... ");
                Console.ReadLine();
                Console.Clear();
                break;
            }
            com[0] = null;
            return;
        }
        /**
        Console.WriteLine("Sphere[name]");
                Console.WriteLine("Light[name]");
                Console.WriteLine("Parent<ParentName> <ChildName>");
                Console.WriteLine("Unparent[node]");
                Console.WriteLine("ReName<OldName> <NewName>");
                Console.WriteLine("Delete<name>");
                Console.WriteLine("Clear");
                Console.WriteLine("Exit");
         * */
    }
         
}
