using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Enemy : GameCharacter
    {
        //fields
        private int x = 40;
        private int y = 11;
       
        //methods
        public Enemy(string name, int health, Map map, char avatar) : base(health, name, map, avatar)
        {
            
        }

        public void Draw()
        {
            //draws enemy to map
            map.TileColour(x, y);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(avatar);
        }

        public void Update()
        {
            //updates enemy on map
            map.DrawTile(x, y);
            RandomMovement();
        }

        public void RandomMovement()
        {
            //generates random number between 0-3 and moves enemy accordingly
            Random randMove = new Random();

            int irandom = randMove.Next(0, 3);

            if (irandom == 0 && map.CheckWall(x, y - 1) == false)
            {
                y--;
            }
            if (irandom ==1 && map.CheckWall(x, y+1) == false)
            {
                y++;
            }
            if (irandom ==2 && map.CheckWall(x-1, y) == false)
            {
                x--;
            }
            if (irandom ==3 && map.CheckWall(x+1, y) == false)
            {
                x++;
            }


        }
    }
}
