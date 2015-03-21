using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maja
{
    static class Creator
    {
        static List <Nodes> nodes = new List<Nodes>();

        public static void CreateSphere(string Name)
        {
            Nodes node = new Nodes(Name);

            nodes.Add(node);
        }

        public static void List()
        {
            foreach (Nodes node in nodes)
            {
                Console.WriteLine(node.name);
            }
        }
        public static void Delete(string Name)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].name == Name)
                {
                    nodes.Remove(nodes[i]);
                    return;
                }
            }
            NotFound();
            return;
        }
        
        public static void Rename(string OldName,string NewName)
        {
            foreach (Nodes node in nodes)
            {
                if (node.name == OldName)
                {
                    node.name = NewName;
                    return;
                }
            }
            NotFound();
            return;
        }

        private static void NotFound()
        { 
         Console.WriteLine("Object Not Found...");
         Console.ReadLine();
         Console.Clear();
         return;
        }

        public static void CreateLight(string Name)
        {
            Light node = new Light(Name);

            nodes.Add(node);
        }
    }
}
