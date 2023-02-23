using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class HUD
    {
        public Player player;

        public HUD()
        {

        }

        public void DisplayHUD()
        {
            Console.WriteLine(player.name);
            Console.WriteLine(player.health);
        }
    }
}
