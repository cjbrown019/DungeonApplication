﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        private int _minDamage;
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (_minDamage >= MaxDamage)
                {
                    _minDamage = MaxDamage;
                }
                else
                {
                    _minDamage = value;
                }
            }
        }
        public string Name { get; set; }

        public int BonusHitChance { get; set; }

        public bool IsTwoHanded { get; set; }

        public Weapon(string name, int maxDamage, int minDamage, int bonusHitChance, bool isTwoHanded)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;

        }

        public override string ToString()
        {
            return string.Format("Name: {0}\n" +
                "Max Damage: {1}\n" +
                "Min Damage: {2}\n" +
                "Bonus Hit Chance: {3}\n" +
                "Two Handed: {4}", Name, MaxDamage, MinDamage, BonusHitChance, IsTwoHanded);
        }
    }
}

       
        
            
       

   

