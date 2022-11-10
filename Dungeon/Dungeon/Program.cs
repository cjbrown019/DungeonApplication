using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(GetRoom());
        }

        public static string GetRoom()
        {
            Random randomNumb = new Random();
            int roomIndex = randomNumb.Next(0,8);
            Console.WriteLine(roomIndex);
            string roomDescription;
            string[] rooms =
            {
                "A dark room. The dimensions are unknown due to how dark it is but with the limited\n" +
                "light you can see 3 statues standing in fron of you. The statues look to be \n" +
                "of a knight, archer, and a wizard. Just past the statues is a door lit by two torches.\n" +
                "The door was a double door made of wood near the handles is what looks like key hole.",
                "Place 2","Place 3","Place 4","Place 5","Place 6","Place 7","Place 8"
            };
            roomDescription = rooms[roomIndex];
            return (roomDescription);
        }
    }
}
