using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    internal class WeaponCreator
    {
        public static void Create()
        {
            Weapon oldAxe = new Weapon("Old Axe", 30, 1, 3, false);
            Weapon greatSword = new Weapon("Great Sword", 40, 1, 3, false);
            Weapon bowAndArrow = new Weapon("Bow and Arrow", 35, 1, 3, false);
            Weapon handAxe = new Weapon("Hand Axe", 20, 1, 3, false);
            Weapon shortSword = new Weapon("Short Sword", 36, 1, 3, false);
            Weapon spear = new Weapon("Spear", 45, 1, 3, false);
            Weapon fireBall = new Weapon("FireBall", 90, 1, 3, true);
            Weapon lightning = new Weapon("Lightning", 30, 1, 3, true);
            Weapon greatAxe = new Weapon("Great Axe", 40, 1, 3, false);

        }
    }
}
