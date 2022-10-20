using System.Collections.Generic;

namespace RoleplayGame
{
    public class Inventory
        {
            private List<Items> inventory = new List<Items>();
            
            public List<Items> GetInventory()
                {
                    return this.inventory;
                }

            public void AddItem(Items item)
            {
                this.inventory.Add(item);
            }

            public void RemoveItem(Items item)
            {
                this.inventory.Remove(item);
            }
        }
}