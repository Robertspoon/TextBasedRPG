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
            Console.WriteLine("Text based RPG");
            Console.WriteLine();
            Console.WriteLine("Press any key to start.....");
            Console.ReadKey(true);
            Console.Clear();

            Console.CursorVisible = false;

            
            Map map = new Map();
            Player player = new Player("Jerald",100,map,'P');
            Enemy enemy = new Enemy("Rat",25,map,'R');

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
