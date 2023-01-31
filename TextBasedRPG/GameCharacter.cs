using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class GameCharacter 
    {
        public int health;
        public string name;
        public Map map;
        public char avatar;


        public GameCharacter(int health, string name, Map map, char avatar)
        {
            this.health = health;
            this.name = name;
            this.map = map;
            this.avatar = avatar;
        }

        


        public void TakeDamage(int hp)
        {
            health -= hp;
            if (health < 0) health = 0;
        }

    }
}
