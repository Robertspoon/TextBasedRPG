using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Player
    {
        //fields
        private int x = 10;
        private int y = 10;


       //methods
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
            if (x >= Console.WindowWidth) x = Console.WindowWidth - 1;
            if (x >= Console.WindowHeight -1) x = Console.WindowHeight - 2;
        }

        public void Draw()
        {
            Console.Clear(); //Remove once map is drawn
            Console.SetCursorPosition(x, y);
            Console.WriteLine("#");
        }
        

       

    }
}
