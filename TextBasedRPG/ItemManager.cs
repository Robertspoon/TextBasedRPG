using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class ItemManager
    {
        public List<Items> Items = new List<Items>();


        public ItemManager()
        {

        }

        public void AddItems(Items healthPotion,Items strengthPotion)
        {
            Items.Add(healthPotion);
            Items.Add(strengthPotion);
        }

    }
}
