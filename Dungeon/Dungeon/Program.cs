﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            bool playerAlive = true;
            
            //make weapon
            Weapon Axe = new Weapon("Axe", 25, 1, 5, true);
            Weapon Sword = new Weapon("Sword", 30, 1, 3, true);
            Weapon Bow = new Weapon("Bow", 15, 1, 3, true);
            //ask for player name
            Console.WriteLine("What is your characters name?");
            string playerName = Console.ReadLine();
            
            Console.Clear();

            //ask for player race
            Console.WriteLine("Chose your characters race.");
            Console.WriteLine("" +
                "1) Human\n" +
                "2) Orc\n" +
                "3) Elf");
            ConsoleKey playerChoice = Console.ReadKey().Key;
            
            //Race is chosen
            Races ChosenRace = new Races();
            switch (playerChoice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ChosenRace = Races.Human;
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ChosenRace = Races.Orc;
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    ChosenRace = Races.Elf;
                    break;
            }
            Console.Clear();

            //ask for player race
            Console.WriteLine("Chose your characters race.");
            Console.WriteLine("" +
                "1) Human\n" +
                "2) Orc\n" +
                "3) Elf");
            ConsoleKey playerChoiceWeapon = Console.ReadKey().Key;

            //Race is chosen
            
            switch (playerChoice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ChosenRace = Races.Human;
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ChosenRace = Races.Orc;
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    ChosenRace = Races.Elf;
                    break;
            }
            Console.Clear();

            //Respond
            Console.WriteLine("You picked {0}",ChosenRace);
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            Player player = new Player(playerName, 17, 9, 100, 100, ChosenRace, Axe);

            //Create Monsters
            Orcs o1 = new Orcs("Orc Minion", 10, 10, 100, 100, 15, 1, "Ugly gross unhygenic orc.",true,false);
            Orcs o2 = new Orcs();
            BugBear bB1 = new BugBear("Bug Bear Lunatic", 16, 17, 100, 100, 30, 1, "A giant hairy crazy humanoid bug bear", true, true);
            BugBear bB2 = new BugBear();
            Vampires v1 = new Vampires("Count Vlad",18,15,100,100,30,1,"A old man with a pale face and a large cape.",true,true);
            Vampires v2 = new Vampires();


            //Monster Pool

            Monster[] monsterPool =
            {
                o1,o1,o1,
                o2,o2,
                bB1,bB1,bB1,
                v1,v1,v1,
                v2,v2,v2,v2
            };
            do
            {
                //Monster Encounter
                Random random = new Random();
                Monster monster = monsterPool[random.Next(monsterPool.Length)];

                string room = GetRoom();
                bool combat = true;

                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(@"
 __| |________________________________________| |__
(__   ________________________________________   __)
   | |                                        | |
   | |                                        | |
   | |           DUNGEON MASTER               | |
   | |                                        | |
 __| |________________________________________| |__
(__   ________________________________________   __)
   | |                                        | |");
                    Console.ResetColor();
                    
                    


                    Console.WriteLine("\n" + room + "\n");

                    Console.WriteLine($"You have encountered a enemy {monster.Name}");

                    Console.WriteLine("\nDo you?\n1) Attack\n2) Check Monster\n3) Player\n4) Run Away");
                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "1":
                            Combat.DoAttack(player, monster);

                            System.Threading.Thread.Sleep(300);

                            if (monster.Life > 0)
                            {
                                Combat.DoAttack(monster,player);
                            }
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine(" ==== Game Over ====");
                            Console.WriteLine($"Score {score}");
                            combat = false;
                            playerAlive = false;
                            break;
                        default:
                            Console.Clear();
                            break;


                            if (monster.Life == 0)
                            {
                                score += 100;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{monster.Name} died");
                                Console.ResetColor();
                                Thread.Sleep(1000);
                                Console.Clear();
                                combat = false;
                            }

                    }
                } while (combat);
            } while (playerAlive);
           
            
        }

        public static string GetRoom()
        {
            Random randomNumb = new Random();
            int roomIndex = randomNumb.Next(0,4);
            
            string roomDescription;
            string[] rooms =
            {
                "In a dark room. The dimensions are unknown due to how dark it is but with the limited\n" +
                "light you can see 3 statues standing in fron of you. The statues look to be \n" +
                "of a knight, archer, and a wizard. Just past the statues is a door lit by two torches.\n" +
                "The door was a double door made of wood near the handles is what looks like key hole.",
                "This room is a medium sized, rough diamond, it was once used as a storage room.\n" +
                "It is completely dark. The smell of burning charcoal lingers in a few distinct spots\n" +
                "within the area. The stone floor is cut such that it spirals downward a total of ten feet\n" +
                "before reaching a small hole in the room’s centre. A jumble of muddy tracks crisscross the floor.\n","" +
                "This room is a medium sized, exact oval, its initial function was as a great hall.\n" +
                "Some small bird or rodent has built a nest on this torch sconce, littering the floor with refuse. \n" +
                "At all times, the area remains refreshingly cool.","" +
                "This room is a medium sized, exact pentagon, it was originally intended to be a vault.\n " +
                "Only a little light can be seen in the room. The air pressure is noticeably different \n" +
                "than of surrounding areas."
            };
            roomDescription = rooms[roomIndex];
            return (roomDescription);
        }
    }
}
