using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class GameCharacter 
    {
        //fields
        public int health;
        public string name;
        public Map map;
        public char avatar;

        //Methods
        public GameCharacter(int health, string name, Map map, char avatar)
        {
            this.health = health;
            this.name = name;
            this.map = map;
            this.avatar = avatar;
        }
        public void TakeDamage(int hp)
        {
            //applies damage to player/enemies
            health -= hp;
            if (health < 0) health = 0;
        }

    }
}
