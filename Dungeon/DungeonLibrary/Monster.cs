using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > MaxDamage)
                {
                    _minDamage = MaxDamage;
                }
                else
                {
                    value = _minDamage;
                }
            }
        }

        public string Description { get; set; }

        public Monster(string name,int hitChance, int block, int maxLife, int life, int maxDamage, int minDamage, string description):base(name, hitChance, block, life, maxLife)  
        {
            
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        public Monster()
        {

        }


        public override int CalcDamage()
        {
            Random random = new Random();

            int damage = random.Next(MaxDamage, MinDamage + 1);
            return damage;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMax Damage: {MaxDamage} \nMin Damage: {MinDamage}\nDescription: {Description}";
        }

    }
}
