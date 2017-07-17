using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToGitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Another damn line...");
            foreach(var str in DisplayStrings())
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }

        static string[] DisplayStrings()
        {
            return new string[] { "String 1", "String 2" };
        }
    }
}
