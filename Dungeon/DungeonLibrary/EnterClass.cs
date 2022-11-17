using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class EnterClass
    {
        public static void EnterToContinue()
        {
            bool enternotpressed = true;
            ConsoleKey consoleKey = new ConsoleKey();
            Console.WriteLine("press 'Enter' to continue");
            do
            {
                consoleKey = Console.ReadKey().Key;
                if (consoleKey == ConsoleKey.Enter)
                {
                    Console.Clear();
                    enternotpressed = false;
                }
                else
                {
                    enternotpressed = true;
                };
            } while (enternotpressed);

        }
    }
}