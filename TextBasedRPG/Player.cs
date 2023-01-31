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
       


        //public int shields;
       // public int lives;
        //public int exp;
       // public int level;


        //methods

        public Player(string name, int health, Map map, char avatar) : base(health, name, map, avatar)
        {
            //this.shields = shields;
           // this.lives = lives;
           // this.exp = exp;
           // this.level = level;
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
            

            //probably will remove later
            if (x < 0) x = 0;
           if (y < 0) y = 0;
           // if (x >= Console.WindowWidth) x = Console.WindowWidth - 1;
           // if (x >= Console.WindowHeight -1) x = Console.WindowHeight - 2;
        }

        public void Draw()
        {
            //Console.Clear(); //Remove once map is drawn
            map.TileColour(x, y);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(avatar);
        }
        

       

    }
}
