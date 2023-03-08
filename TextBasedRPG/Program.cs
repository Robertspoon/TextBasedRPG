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
            Console.WriteLine("Beta");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to start.....");
            Console.ReadKey(true);
            Console.Clear();

            Console.CursorVisible = false;

            GameManager gameManager = new GameManager();


            gameManager.RunGame();

            Console.ReadKey(true);
        }
    }
}
