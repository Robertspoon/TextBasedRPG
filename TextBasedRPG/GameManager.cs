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
        public Rat rat;
        public EnemyManager eManager;
        public Skeleton skeleton;
        public Goblin goblin;
        public Items items;
        public HUD hud;

        public GameManager()
        {
            map = new Map();
            eManager = new EnemyManager();
            player = new Player("Jeremy", 5, map, 'P', eManager,rat);
            rat = new Rat("Rat", 3, map, 'R', player);
            skeleton = new Skeleton("Skeleton", 7, map, '@', player);
            goblin = new Goblin("Goblin", 5, map, '#', player);
            items = new Items(map, player, '†');
            hud = new HUD();
            eManager.AddEnemy(rat);
          
        }

        public void RunGame()
        {
            map.DrawMap();
            //Main Game Loop
            while (true)
            {
                rat.Draw();
                skeleton.Draw();
                goblin.Draw();
                items.DrawHealthPot();
                player.Draw();
                player.Update();
                rat.Update();
                skeleton.Update();
                goblin.Update();
            }
        }
    }
}
