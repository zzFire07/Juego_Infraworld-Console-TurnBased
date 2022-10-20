using System.Collections.Generic;
namespace RoleplayGame
{
    public class SpellBook : IItem
    {
        public SpellBook()
        {
            private List<Spell> spells = new List<Spell>();
            public void AddSpell(Spell spell)
            {
                this.spells.Add(spell);
            }
            public void RemoveSpell(Spell spell)
            {
                this.spells.Remove(spell);
            }
            public void UseSpell(Spell spell)
            {
                this.spells.Remove(spell);
                return spell.AttackValue;
            }

            
        }
    }
}