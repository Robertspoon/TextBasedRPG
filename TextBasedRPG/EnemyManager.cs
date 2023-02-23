using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class EnemyManager
    {
        public List<Enemy> Enemies = new List<Enemy>();


        public void AddEnemy(Enemy badguy)
        {
            Enemies.Add(badguy);
        }

        public Enemy GetEnemyAt(int x, int y)
        {
            //checks the position of enemies in list
            Enemy badguy = null;
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
