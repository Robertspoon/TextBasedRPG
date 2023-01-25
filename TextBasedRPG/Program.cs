using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Text based RPG");

            Console.CursorVisible = false;

            GameCharacter gameCharacter = new GameCharacter(1000000,"GameCharacter");
            Player player = new Player("Jerald",100,100,3,0,1);
            Enemy enemy = new Enemy("Rat", 50);


            while(true)
            {
                player.Update();
                player.Draw();
                enemy.DrawEnemy();
            }

            Console.ReadKey(true);
        }
    }
}
