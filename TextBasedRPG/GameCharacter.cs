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
        public bool alive;

        //Methods
        public GameCharacter(int health, string name, Map map, char avatar)
        {
            this.health = health;
            this.name = name;
            this.map = map;
            this.avatar = avatar;
            alive = true;
        }
        public void TakeDamage(int hp)
        {
            //applies damage to player/enemies
            health -= hp;
            if (health < 0)
            {
                health = 0;
            }
        }
        public void ApplyDamage()
        {
            //Calculates damage done to enemy/player
            Random damage = new Random();
            int dmgRandom = damage.Next(1, 2);

            TakeDamage(dmgRandom);
        }
        public void OnDeath()
        {
            if (health == 0)
            {
                alive = false;
            }
        }
    }
}
