using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class MediumEnemy : GameCharacter
    {
       public int x = 20;
       public int y = 5;
       public Player player;
        public MediumEnemy(string name, int health, Map map, char avatar,Player player) : base(health, name, map, avatar)
        {
            this.player = player;
        }

        public void Draw()
        {
            map.TileColour(x, y);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(avatar);
        }

        public void Update()
        {
            OnDeath();
            map.DrawTile(x, y);
        }
    }
}
