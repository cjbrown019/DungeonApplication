using DungeonLibrary;
using System;
using Xunit;

namespace DungeonTests
{
    public class CombatTests
    {
        [Fact]
        public void Player_Caculation_of_HC()
        {
            Weapon oldAxe = new Weapon("Old Axe", 30, 1, 3, false);
            Player player = new Player("Gene", 15, 10, 100, 100, Races.Elf, oldAxe);

            int hitCalc = player.CalcHitChance();

            Assert.True(hitCalc > 15);
        }

        [Fact]
        public void Player_Caculation_of_BC()
        {
            Weapon oldAxe = new Weapon("Old Axe", 30, 1, 3, false);
            Player player = new Player("Gene", 15, 10, 100, 100, Races.Elf, oldAxe);

            int calcBlock = player.CalcBlock();

            Assert.True(calcBlock > 10);
        }

        [Fact]
        public void monster_Caculation_of_BC()
        {
            Vampires vamp = new Vampires("CountDummy",13,8,100,100,32,1,"A normal guy we thought was a vampire",true,true);

            int calcBlock = vamp.CalcBlock();

            Assert.True(calcBlock > 12);
        }
    }
}