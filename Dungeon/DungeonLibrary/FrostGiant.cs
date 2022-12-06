using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal sealed class FrostGiant : Monster
    {
        public bool Old { get; set; }
        public bool ThickSkin { get; set; }

        public FrostGiant(string name, int hitChance, int block, int maxLife, int life, int maxDamage, int minDamage, string description, bool old, bool thickSkin) : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description)
        {
            Old = old;
            ThickSkin = thickSkin;
        }

        public FrostGiant()
        {
            Name = "Frost Giant";
            HitChance = 10;
            Block = 10;
            MaxLife = 100;
            Life = 100;
            MaxDamage = 50;
            MinDamage = 1;
            Description = "Giant blue ";
            Old = false;
            ThickSkin = false;

        }

        public override string ToString()
        {
            return base.ToString() + $"\nOld: {Old}\nThick Skin: {ThickSkin}";
        }

        public override int CalcBlock()
        {

            if (ThickSkin)
            {
                return Block += Block;
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
                return damage / 10;
            }
            else
            {
                return damage;
            }
        }
    }
}
