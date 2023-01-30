using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Enemy : GameCharacter
    {

        private int x = 40;
        private int y = 11;

        public Enemy(string name, int health) : base(health, name)
        {
            
        }

        public void DrawEnemy()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("R");
        }
    }
}
