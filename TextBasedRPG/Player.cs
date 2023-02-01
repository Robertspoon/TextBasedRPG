using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Player : GameCharacter
    {
        //fields
        private int x = 25;
        private int y = 10;
  
        //methods

        public Player(string name, int health, Map map, char avatar) : base(health, name, map, avatar)
        {
            
        }
       public void Update()
       {
           //gets player input
           ConsoleKeyInfo input;
           input = Console.ReadKey(true);
           
            map.DrawTile(x, y);
            if ((input.KeyChar == 'w' || input.Key == ConsoleKey.UpArrow) && map.CheckWall(x, y-1) == false)
            {
                y--;
            }
            if ((input.KeyChar == 's' || input.Key == ConsoleKey.DownArrow) && map.CheckWall(x, y+1) == false)
            {
                y++;
            }
            if ((input.KeyChar == 'a' || input.Key == ConsoleKey.LeftArrow) && map.CheckWall(x-1, y) == false)
            {
                x--;
            }
            if ((input.KeyChar == 'd' || input.Key == ConsoleKey.RightArrow) && map.CheckWall(x+1, y) == false)
            {      
                x++;
            }
       }

        public void Draw()
        {
            //Draws player to map
            map.TileColour(x, y);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(avatar);
        }
    }
}
