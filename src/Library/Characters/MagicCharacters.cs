using System.Collections.Generic;
namespace RoleplayGame
{
    public class MagicCharacter
    {
        private List<IMagicItem> magicItems = new List<IMagicItem>();
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IMagicItem item in this.magicItems)
                {
                    if (item is IAttackMagic)
                    {
                        value += (item as IAttackMagic).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IMagicItem item in this.magicItems)
                {
                    if (item is IDefenseMagic)
                    {
                        value += (item as IDefenseMagic).DefenseValue;
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

        public void EquipItem(IMagicItem item )
        {
            magicItems.Add(item);
        }
        public void UnequipItem(IMagicItem item)
        {
            magicItems.Remove(item);
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