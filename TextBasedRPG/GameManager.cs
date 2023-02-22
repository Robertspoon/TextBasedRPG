using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class GameManager
    {
        public Map map;
        public Player player;
        public Enemy enemy;
        public EnemyManager eManager;
        public MediumEnemy mediumEnemy;

        public GameManager(Map map, Player player, Enemy enemy, MediumEnemy mediumEnemy,EnemyManager eManager)
        {
            Map map = new Map();
            EnemyManager enemyManager = new EnemyManager();
            Player player = new Player("Jeremy", 5, 5, map, 'P', enemyManager);
            Enemy enemy = new Enemy("Rat", 5, map, 'R', player);
            MediumEnemy mediumEnemy = new MediumEnemy("Skeleton", 10, map, '@', player);
            enemyManager.AddEnemy(enemy);
        }

        public void RunGame()
        {
            map.DrawMap();
            //Main Game Loop
            while (true)
            {
                player.Draw();
                enemy.Draw();
                mediumEnemy.Draw();
                player.Update();
                enemy.Update();
            }
        }
    }
}
