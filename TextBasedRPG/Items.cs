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
        public char avatar1;
        public char avatar2;
        public char avatar3;
        public char[] avatars;
        
        public Items(Map map, Player player, char avatar1, char avatar2, char avatar3)
        {
            this.avatar1 = avatar1;
            this.avatar2 = avatar2;
            this.avatar3 = avatar3;
            avatars[0] = avatar1;
            avatars[1] = avatar2;
            avatars[2] = avatar3;
        }

        public void DrawHealthPot()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(avatar1);
        }


        public void Use()
        {
           

        }
    }
}
