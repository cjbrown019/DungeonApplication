using System;
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
            bool combat = true;
            //make weapon
            Weapon Axe = new Weapon("Axe", 30, 1, 5, true);

            //ask for player
            Console.WriteLine("What is your name?\n");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName, 13, 15, 100, 100, Races.Human, Axe);

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
                Monster Monster = monsterPool[random.Next(monsterPool.Length)];

                string room = GetRoom();
                
                bool fightMenu = true;
                do
                {
                    Console.WriteLine("----=== Master Dungeon ===----");

                    Console.WriteLine(room);

                    Console.WriteLine($"You have encountered a enemy {Monster.Name}");

                    Console.WriteLine("\nDo you?\n1) Attack\n2) Check Monster\n3) Player\n4) Run Away");
                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "1":
                            do
                            {
                                //TODO: Add Combat menu
                            } while (fightMenu);
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine(" ==== Game Over ====");
                            Console.WriteLine($"Score {score}");
                            gameRun = false;
                            playerAlive = false;
                            break;
                        default:
                            Console.Clear();
                            break;

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
