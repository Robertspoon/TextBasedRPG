using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class GameCharacter : Map
    {
        public int health;
        public string name;
        public Map map;


        public GameCharacter(int health, string name)
        {
            this.health = health;
            this.name = name;
            this.map = map;
        }

        public void MoveUp()
        {

        }

        public void MoveDown()
        {

        }
        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }
        public void TakeDamage(int hp)
        {
            health -= hp;
            if (health < 0) health = 0;
        }

    }
}
