﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{

    internal class Map
    {
        static char[,] map = new char[,] 
         {
            {'^','^','^','^','^','^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','^','^','^','^','^'},
            {'^','^','^','^','^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','~','~','^','^'},
            {'^','^','^','^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','~','~','~','^','^'},
            {'^','^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','*','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','~','`','`'},
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','~','~','`','`'},
            {'^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','~','~','`','`','`','`'},
            {'`','`','`','`','`','`','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','~','~','~','~','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','~','~','~','~','~','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','~','~','~','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','~','~','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','~','~','~','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','~','~','~','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','*','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','*','*','`','`','`','`','`','`','`','`','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','*','*','*','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','`','`','`','`','`','`','`','`','^','^','^','`','`'},
            {'`','`','`','`','`','`','`','`','`','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','^','^'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','^','^','^'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','^','^','^'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','^','^','^','^'},
            

         };
        private char[] borderSides = new char[] { '║', '═' };
        private char[] borderEdges = new char[] { '╔', '╗', '╚', '╝' };

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees
        // Ó = apples
        // - = snow

        public Map()
        {

        }
        public void Update()
        {

        }

        public void DrawMap()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(borderEdges[0]);
            for (int top = 0; top < map.GetLength(1); top++)
            {
                Console.Write(borderSides[1]);
            }
            Console.Write(borderEdges[1]);
            Console.WriteLine();

            for(int x = 0; x< map.GetLength(0); x++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(borderSides[0]);
                for (int y = 0; y< map.GetLength(1); y++)
                {
                    TileColour(y, x);
                    Console.Write(map[x, y]);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(borderSides[0]);
                Console.WriteLine();

            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(borderEdges[2]);
            for (int bottom = 0; bottom < map.GetLength(1); bottom++)
            {
                Console.Write(borderSides[1]);
            }
            Console.Write(borderEdges[3]);
            Console.WriteLine();
            
        }
        public void TileColour(int x, int y)
        {
            switch (map[y, x])
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

                case 'Ó':
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;

                case '-':
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }
        }
        public bool CheckWall(int x, int y)
        {
            try
            {
                switch (map[y, x])
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
