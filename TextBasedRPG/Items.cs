using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Items
    {
      
        public int x = 7;
        public int y = 15;
        public Player player;
        public Map map;
        public char avatar;
        
        
        public Items(Map map, Player player, char avatar)
        {
            
           
        }

        public void DrawHealthPot()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(avatar);
        }


        public void Use()
        {
           

        }
    }
}
