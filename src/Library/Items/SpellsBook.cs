using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook
    {
        public List<Spell> Spells = new List<Spell>();
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
        public void AddSpell()
        {
            Spell spell = new Spell();
            Spells.Add(spell);
        }
    }
}