using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Items
    {
        public ItemManager iManager;

        public int x = 7;
        public int y = 15;
        public Player player;
        public Map map;
        public char avatar;
        public Items(Map map, Player player, char avatar)
        {
            this.avatar = avatar;
        }

        public void Draw()
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
