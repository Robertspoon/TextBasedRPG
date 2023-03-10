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

        public void Update()
        {
            OnDeath();
            map.DrawTile(x, y);
            Move();
        }
        public void Move()
        {
            Random randMove = new Random();
            int irandom = randMove.Next(0, 4);
            if (alive)
            {
                
                if (irandom == 2 && map.CheckifWall(x - 1, y) == false && player.x != x - 1 && player.y != y)
                {
                    x -= 2;
                }
                else if (irandom == 2 && player.x == x - 1 && player.y == y)
                {
                    player.TakeDamage();
                }
                if (irandom == 3 && map.CheckifWall(x + 1, y) == false && player.x != x + 1 && player.y != y)
                {
                    x += 2;
                }
                else if (irandom == 3 && player.x == x + 1 && player.y == y)
                {
                    player.TakeDamage();
                }
            }
        }
    }
}
