namespace RoleplayGame
{
    public class Wizard : MagicCharacter, IHeroes
    {
        public SpellsBook spellsBook { get; set; } = new SpellsBook();

        public Wizard(string name) : base(name)
        {
            Staff staff = new Staff();

            this.EquipItem(staff);
            this.EquipItem(spellsBook);
        }
    }
}