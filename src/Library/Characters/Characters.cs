using System.Collections.Generic;
namespace RoleplayGame
{
    public class Characters
    {
        public IList<IItem> items = new List<IItem>();
        public string Name { get; set; }
        public int Health { get; set; } = 100;

        public Characters(string name)
        {
            this.Name = name;
        }

        public virtual int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }
        public virtual int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }
        public bool IsDead
        {
            get
            {
                return this.Health <= 0;
            }
        }
        public void EquipItem(IItem item)
        {
            items.Add(item);
        }
        public void UnequipItem(IItem item)
        {
            items.Remove(item);
        }
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }
        public void Cure()
        {
            this.Health = 100;
        }
    }
}