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
        private int y = 10;

        public int shields;
        public int lives;
        public int exp;
        public int level;


        //methods

        public Player(string name, int health, int shields, int lives, int exp, int level) : base(health, name)
        {
            this.shields = shields;
            this.lives = lives;
            this.exp = exp;
            this.level = level;
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
            
            //probably will remove later
            if (x < 0) x = 0;
           if (y < 0) y = 0;
           // if (x >= Console.WindowWidth) x = Console.WindowWidth - 1;
           // if (x >= Console.WindowHeight -1) x = Console.WindowHeight - 2;
        }

        public void Draw()
        {
            Console.Clear(); //Remove once map is drawn
            Console.SetCursorPosition(x, y);
            Console.WriteLine("#");
        }
        

       

    }
}
