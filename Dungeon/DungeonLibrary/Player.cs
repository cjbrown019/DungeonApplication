using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        public Races Races { get; set; }

        public Weapon EquipedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int life, int maxLife, Races races, Weapon equipedWeapon):base(name, hitChance, block, life, maxLife)  
        {
            Races = races;
            EquipedWeapon = equipedWeapon;
        }


        public override string ToString()
        {
            string raceDescription = "";
            switch (Races)
            {
                case Races.Human:
                    raceDescription = "A normal dude";
                    break;
                case Races.Orc:
                    raceDescription = "AND MY AXE";
                    break;
                case Races.Elf:
                    raceDescription = "A regal, magical being";
                    break;
                default:
                    break;

                    
            }

            return base.ToString() + "\nDesctiption: " + raceDescription + "\nWeapon: " + EquipedWeapon;
        }


        public override int CalcDamage()
        {
            Random random = new Random();

            int damage = random.Next(EquipedWeapon.MinDamage,EquipedWeapon.MaxDamage + 1);
            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquipedWeapon.BonusHitChance;
        }

    }
}
