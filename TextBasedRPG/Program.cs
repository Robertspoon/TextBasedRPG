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

            Player player = new Player();

            while(true)
            {
                player.Update();
                player.Draw();
            }

            Console.ReadKey(true);
        }
    }
}
