using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class EnemyManager
    {
        public List<Rat> Enemies = new List<Rat>();


        public void AddEnemy(Rat badguy)
        {
            Enemies.Add(badguy);
        }

        public Rat GetEnemyAt(int x, int y)
        {
            //checks the position of enemies in list
            Rat badguy = null;
            for(int i = 0; i< Enemies.Count; i++)
            {
                if (Enemies[i].x == x && Enemies[i].y == y)
                {
                    badguy = Enemies[i];
                }
            }
            return badguy;
        }
    }

}
