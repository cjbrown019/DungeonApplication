using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            Console.Clear();
            bool inCombat = true;
            

            Thread.Sleep(3000);

            int atkHC = attacker.CalcHitChance();
            int defendCB = defender.CalcBlock();

            if (atkHC >= defendCB)
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;
                if (defender.Life < 0)
                {
                    defender.Life = 0;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} did {1} damage leaving {2} with {3} health!\n",attacker.Name,damageDealt,defender.Name,defender.Life);
                Console.ResetColor();
                
            }
            else
            {
                Console.WriteLine("{1} missed {0}!",defender.Name,attacker.Name);
            }
            EnterClass.EnterToContinue();

        }


    }
}
