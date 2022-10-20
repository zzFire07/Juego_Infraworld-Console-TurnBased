using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoleplayGame
{
    public interface Items
    {
        protected int attackValue { get; set; }  
        protected int defenseValue { get; set; } 
        protected  Boolean isMagic { get; set; }


        public int AttackValue()
        {
            return this.attackValue;
        }
     
        public int DefenseValue()
        {
            return this.defenseValue;
        }

        public Boolean IsMagic()
        {
            return this.isMagic;
        }
        

       
       
       
       
        public void EquipItem(Items item)
        {
            Inventory.AddItem(item);
        }


        public void UnEquipItem(Items item)
        {
            Inventory.RemoveItem(item);
        }



    }

}