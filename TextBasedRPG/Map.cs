using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{

    internal class Map
    {
        //fields
        private string[] map = System.IO.File.ReadAllLines("map.txt");
        public HUD hud;

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees
        // Ó = apples
        // - = snow

        //Methods
        public Map()
        {

        }
        

        public void DrawTile(int x, int y)
        {
            //Draws each tile in map
            Console.SetCursorPosition(x, y);
            TileColour(x, y);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(map[y][x]);
        }
        
        public void DrawMap()
        {
            //Draws the map
            for(int x = 0; x< map.GetLength(0); x++)
            {
                for (int y = 0; y< map[x].Length; y++)
                {
                    TileColour(y, x);
                    Console.Write(map[x][y]);
                }
                Console.WriteLine();
            }    
        }
        public void TileColour(int x, int y)
        {
            //checks each tile and assigns colour according to which tile it is
            switch (map[y][x])
            {

                case '`':
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;

                case '^':
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;

                case '~':
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;

                case '*':
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;

                case '"':
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
            }
        }
        public bool CheckifWall(int x, int y)
        {
            //will definetly change in later version once border is properly implemented
            try
            {
                switch (map[y][x])
                {
                    case '^':
                    case '~':
                    case '*':
                        return true;
                    case '`':
                    default:
                        return false;
                }
            }
            catch (Exception)
            {
                return true;
            }
        }


    }
}
