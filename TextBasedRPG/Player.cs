using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Player : GameCharacter
    {
        //fields
        public int x = 25;
        public int y = 10;
        public EnemyManager eManager;
  
        //methods

        public Player(string name, int health, Map map, char avatar,EnemyManager eManager) : base(health, name, map, avatar)
        {
            this.eManager = eManager;
        }
       public void Update()
       {
            OnDeath();
            Move();
       }

        public void Draw()
        {
            //Draws player to map
            map.TileColour(x, y);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(avatar);
        }
        public void Move()
        {
            //gets player input
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            if (alive)
            {
                map.DrawTile(x, y);
                if ((input.KeyChar == 'w' || input.Key == ConsoleKey.UpArrow) && map.CheckWall(x, y - 1) == false && eManager.CheckPosition(x, y - 1) == null)
                {
                    y--;
                }
                else if (eManager.CheckPosition(x, y - 1) != null)
                {
                    eManager.CheckPosition(x, y - 1).ApplyDamage();
                }
                if ((input.KeyChar == 's' || input.Key == ConsoleKey.DownArrow) && map.CheckWall(x, y + 1) == false && eManager.CheckPosition(x, y + 1) == null)
                {
                    y++;
                }
                else if (eManager.CheckPosition(x, y + 1) != null)
                {
                    eManager.CheckPosition(x, y + 1).ApplyDamage();
                }
                if ((input.KeyChar == 'a' || input.Key == ConsoleKey.LeftArrow) && map.CheckWall(x - 1, y) == false && eManager.CheckPosition(x - 1, y) == null)
                {
                    x--;
                }
                else if (eManager.CheckPosition(x - 1, y) != null)
                {
                    eManager.CheckPosition(x - 1, y).ApplyDamage();
                }
                if ((input.KeyChar == 'd' || input.Key == ConsoleKey.RightArrow) && map.CheckWall(x + 1, y) == false && eManager.CheckPosition(x + 1, y) == null)
                {
                    x++;
                }
                else if (eManager.CheckPosition(x + 1, y) != null)
                {
                    eManager.CheckPosition(x + 1, y).ApplyDamage();
                }
            }
        }
    }
}
