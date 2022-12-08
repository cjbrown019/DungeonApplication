using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class BugBear : Monster
    {
        public bool Strong { get; set; }
        public bool Tall { get; set; }

        public BugBear(string name, int hitChance, int block, int maxLife, int life, int maxDamage, int minDamage, string description, bool strong, bool thickSkin) : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description)
        {
            Strong = strong;
            Tall = thickSkin;
        }

        public BugBear()
        {
            Name = "Bug Bear Grunt";
            HitChance = 10;
            Block = 6;
            MaxLife = 100;
            Life = 100;
            MaxDamage = 35;
            MinDamage = 1;
            Description = "A hairy half goblin huminoid monster weilding a giant two handed axe";
            Strong = false;
            Tall = false;

        }

        public override string ToString()
        {
            return base.ToString() + $"\nStrong: {Strong}\nTall: {Tall}";
        }

        public override int CalcBlock()
        {

            if (Tall)
            {
                return Block += 10;
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
