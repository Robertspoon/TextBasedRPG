using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Skeleton : GameCharacter
    {
       public int x = 20;
       public int y = 5;
       public Player player;
        public Skeleton(string name, int health, Map map, char avatar,Player player) : base(health, name, map, avatar)
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
            Move();
        }

        public void Move()
        {
            Random randMove = new Random();
            int irandom = randMove.Next(0, 4);
            if (alive)
            {
                if (irandom == 0 && map.CheckifWall(x, y - 1) == false && player.x != x && player.y != y - 1)
                {
                    y--;
                }
                else if (irandom == 0 && player.x == x && player.y == y - 1)
                {
                    player.TakeDamage();
                }
                if (irandom == 1 && map.CheckifWall(x, y + 1) == false && player.x != x && player.y != y + 1)
                {
                    y++;
                }
                else if (irandom == 1 && player.x == x && player.y == y + 1)
                {
                    player.TakeDamage();
                }
            }
        }
    }
}
