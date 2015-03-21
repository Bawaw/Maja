using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maja
{
    static class NameProcessor
    {
        static List <string> names = new List<string>();

        static public string NewName(string name)
        {
            int i = 1;
            foreach (string ExistName in names)
            {
                while (name == ExistName)
                {
                    name += i.ToString();
                    i++;
                }
            }

            names.Add(name);
            return name;
        }
        static public void CallList()
        { 
            Console.WriteLine("there are " + names.Count() +" names");
            foreach (string name in names)
                Console.WriteLine(name);
        }



    }
}
