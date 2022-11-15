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

            Console.WriteLine("----=== Master Dungeon ===----");

            Console.WriteLine(GetRoom());
        }

        public static string GetRoom()
        {
            Random randomNumb = new Random();
            int roomIndex = randomNumb.Next(0,6);
            
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
