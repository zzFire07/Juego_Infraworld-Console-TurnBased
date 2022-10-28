using System.Collections.Generic;
namespace RoleplayGame
{
    public class MagicCharacters : Characters
    {
        public IList<IMagicItem> magicitems = new List<IMagicItem>();
        
        public MagicCharacters(string name) : base(name)
        {
            
        }

        public override int AttackValue
        {
            get
            {
                int value = base.AttackValue;

                foreach (IMagicItem item in this.magicitems)
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

                foreach (IMagicItem item in this.magicitems)
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
            magicitems.Add(item);
        }

        public void UnequipItem(IMagicItem item)
        {
            magicitems.Remove(item);
        }
    }
}