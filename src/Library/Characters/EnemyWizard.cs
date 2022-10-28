namespace RoleplayGame
{
    public class EnemyWizard : MagicCharacter, IEnemies
    {
        public SpellsBook spellsBook { get; set; } = new SpellsBook();

        public EnemyWizard(string name) : base(name)
        {
            this.VictoryPoints = 25;

            Staff staff = new Staff();
            
            this.EquipItem(staff);
            this.EquipItem(spellsBook);
        }
    }
}