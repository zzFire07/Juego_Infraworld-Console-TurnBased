using System.Collections.Generic;
namespace RoleplayGame
{
    public class MagicCharacter : Characters
    {
        public IList<IMagicItem> magicItems = new List<IMagicItem>();
        
        public MagicCharacter(string name) : base(name)
        {
            
        }

        public override int AttackValue
        {
            get
            {
                int value = base.AttackValue;

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

        public override int DefenseValue
        {
            get
            {
                int value = base.DefenseValue;

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

        public void EquipItem(IMagicItem item )
        {
            magicItems.Add(item);
        }

        public void UnequipItem(IMagicItem item)
        {
            magicItems.Remove(item);
        }
    }
}