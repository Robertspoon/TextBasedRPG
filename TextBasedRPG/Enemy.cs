using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Enemy : GameCharacter
    {

        private int x = 40;
        private int y = 11;
       

        public Enemy(string name, int health, Map map, char avatar) : base(health, name, map, avatar)
        {
            
        }

        public void Draw()
        {
            map.TileColour(x, y);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(avatar);
        }

        public void Update()
        {
            map.DrawTile(x, y);
            if (map.CheckWall(x+1, y) == false)
            {
               x++;
            }
            
            
        }
    }
}
