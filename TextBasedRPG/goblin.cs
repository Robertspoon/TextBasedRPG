using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Goblin : GameCharacter
    {
        public int x = 30;
        public int y = 20;
        public Player player;

        public Goblin(string name, int health, Map map, char avatar, Player player) : base(health, name, map, avatar)
        {
            this.player = player;
        }

        public void Draw()
        {
            map.TileColour(x, y);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(avatar);
        }
    }
}
