using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Enemy : GameCharacter
    {

        private int x = 50;
        private int y = 10;
        private int expYield;

        public Enemy(string name, int health, int expYield) : base(health, name)
        {
            this.expYield = expYield;
        }

        public void DrawEnemy()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("R");
        }
    }
}
