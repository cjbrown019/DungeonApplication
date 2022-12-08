using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Vampires : Monster
    {
        public bool Old { get; set; }
        public bool MoreBat { get; set; }

        public Vampires(string name, int hitChance, int block, int maxLife, int life, int maxDamage, int minDamage, string description, bool old, bool moreBat) : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description)
        {
            Old = old;
            MoreBat = moreBat;
        }

        public Vampires()
        {
            Name = "Vampire";
            HitChance = 16;
            Block = 10;
            MaxLife = 100;
            Life = 100;
            MaxDamage = 50;
            MinDamage = 1;
            Description = "Pale man with a cape and a hood with semi hidden fangs.";
            Old = false;
            MoreBat = false;

        }

        public override string ToString()
        {
            return base.ToString() + $"\nOld: {Old}\nMore bat then human: {MoreBat}";
        }

        public override int CalcBlock()
        {

            if (MoreBat)
            {
                return Block + 4;
            }
            else
            {
                return Block;
            }

        }

        public override int CalcDamage()
        {
            Random random = new Random();

            int damage = random.Next(MinDamage, MaxDamage + 1);
            if (Old)
            {
                return damage += 25;
            }
            else
            {
                return damage;
            }
        }
    }
}
