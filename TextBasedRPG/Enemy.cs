using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Rat : GameCharacter
    {
        //fields
        public int x = 40;
        public int y = 11;
        public Player player;
        public Rat rat;
       
        //methods
        public Rat(string name, int health, Map map, char avatar, Player player) : base(health, name, map, avatar)
        {
            this.player = player;
        }
        public void Draw()
        {
            //draws enemy to map
            map.TileColour(x, y);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(avatar);
        }
        public void Update()
        {
            //updates enemy on map
            OnDeath();
            map.DrawTile(x, y);
            Move();
        }
        public void Move()
        {
            //generates random number between 0-3, moves enemy accordingly, and checks for collision
            Random randMove = new Random();

            int irandom = randMove.Next(0, 4);
            if (alive)
            {
                if (irandom == 0 && map.CheckWall(x, y - 1) == false && player.x != x && player.y != y - 1)
                {
                    y--;
                }
                else if (irandom == 0 && player.x == x && player.y == y - 1)
                {
                    player.TakeDamage();
                }
                if (irandom == 1 && map.CheckWall(x, y + 1) == false && player.x != x && player.y != y + 1)
                {
                    y++;
                }
                else if (irandom == 1 && player.x == x && player.y == y + 1)
                {
                    player.TakeDamage();
                }
                if (irandom == 2 && map.CheckWall(x - 1, y) == false && player.x != x - 1 && player.y != y)
                {
                    x--;
                }
                else if (irandom == 2 && player.x == x - 1 && player.y == y)
                {
                    player.TakeDamage();                  
                }
                if (irandom == 3 && map.CheckWall(x + 1, y) == false && player.x != x + 1 && player.y != y)
                {
                    x++;
                }
                else if (irandom == 3 && player.x == x + 1 && player.y == y)
                {
                    player.TakeDamage();
                }
            }
        }
    }
}
