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
            //Pseudo starting screen
            Console.WriteLine("Robert Atkinson's Text Based RPG");
            Console.WriteLine();
            Console.WriteLine("First Playable");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to start.....");
            Console.ReadKey(true);
            Console.Clear();

            Console.CursorVisible = false;

            Map map = new Map();
            EnemyManager enemyManager = new EnemyManager();
            Player player = new Player("Jeremy", 5, map, 'P', enemyManager);
            Enemy enemy = new Enemy("Rat",5,map,'R', player);
            enemyManager.AddEnemy(enemy);

            map.DrawMap();
            //Main Game Loop
            while(true)
            {
               player.Draw();
               enemy.Draw();    
               player.Update();
               enemy.Update();
            }
            Console.ReadKey(true);
        }
    }
}
