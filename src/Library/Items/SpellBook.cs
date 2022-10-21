using System.Collections.Generic;
namespace RoleplayGame
{
    public class SpellBook : IItems
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

        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public bool isMagic { get; set; }
    }
}
