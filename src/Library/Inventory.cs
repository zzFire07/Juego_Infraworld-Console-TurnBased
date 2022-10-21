using System.Collections.Generic;

namespace RoleplayGame
{
    public class Inventory
        {
            private List<IItems> inventory = new List<IItems>();
            
            public List<IItems> GetInventory()
                {
                    return this.inventory;
                }

            public void AddItem(IItems item)
            {
                this.inventory.Add(item);
            }

            public void RemoveItem(IItems item)
            {
                this.inventory.Remove(item);
            }
        }
}