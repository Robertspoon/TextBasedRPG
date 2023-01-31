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
        private int x = 10;
        private int y = 15;

        //public int shields;
       // public int lives;
        //public int exp;
       // public int level;


        //methods

        public Player(string name, int health) : base(health, name)
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
           
            if (input.KeyChar == 'w')
            {
                y--;
            }
            if (input.KeyChar == 's')
            {
                y++;
            }
            if (input.KeyChar == 'a')  
            {
                x--;
            }
            if (input.KeyChar == 'd')
            {
                x++;
            }
            if (input.Key == ConsoleKey.UpArrow)
            {
                y--;
            }
            if (input.Key == ConsoleKey.DownArrow)
            {
                y++;
            }
            if (input.Key == ConsoleKey.LeftArrow)
            {
                x--;
            }
            if (input.Key == ConsoleKey.RightArrow)
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
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("#");
        }
        

       

    }
}
