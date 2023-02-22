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
        public MediumEnemy medEnemy;
        public Goblin goblin;
        public Items items;

        public GameManager()
        {
            map = new Map();
            eManager = new EnemyManager();
            player = new Player("Jeremy", 5, map, 'P', eManager);
            enemy = new Enemy("Rat", 3, map, 'R', player);
            medEnemy = new MediumEnemy("Skeleton", 7, map, '@', player);
            goblin = new Goblin("Goblin", 5, map, '#', player);
            items = new Items(map, player, '†');
            eManager.AddEnemy(enemy);
        }

        public void RunGame()
        {
            map.DrawMap();
            //Main Game Loop
            while (true)
            {
                player.Draw();
                enemy.Draw();
                medEnemy.Draw();
                goblin.Draw();
                items.Draw();
                player.Update();
                enemy.Update();
                medEnemy.Update();
            }
        }
    }
}
