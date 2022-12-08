using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Orcs : Monster
    {
        public bool Strong { get; set; }
        public bool ThickSkin { get; set; }

        public Orcs( string name, int hitChance, int block, int maxLife, int life, int maxDamage, int minDamage, string description, bool strong, bool thickSkin) :base(name,hitChance,block,maxLife,life,maxDamage,minDamage,description)
        {
            Strong = strong;
            ThickSkin = thickSkin;
        }

        public Orcs()
        {
            Name = "Orc Soldier";
            HitChance = 15;
            Block = 3;
            MaxLife = 100;
            Life = 100;
            MaxDamage = 20;
            MinDamage = 1;
            Description = "A big hairy grey huminoid Orc with tattered clothes.";
            Strong = false;
            ThickSkin = false;

        }

        public override string ToString()
        {
            return base.ToString() + $"\nStrong: {Strong}\nThick Skin: {ThickSkin}";
        }

        public override int CalcBlock()
        {

            if (ThickSkin)
            {
                Random random = new Random();
                int blockChance = random.Next(20);

                return blockChance + 5;
            }
            else
            {
                Random random = new Random();
                int blockChance = random.Next(20);
                return Block;
            }
            
        }

        public override int CalcDamage()
        {
            Random random = new Random();

            int damage = random.Next(MinDamage, MaxDamage + 1);
            if (Strong)
            {
                return damage + 10;
            }
            else
            {
                return damage;
            }
        }
    }


}
