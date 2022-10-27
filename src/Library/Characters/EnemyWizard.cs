namespace RoleplayGame
{
    public class EnemyWizard : MagicCharacter, IEnemies
    {
        public EnemyWizard(string name) : base(name)
        {
            this.VictoryPoints = 25;

            Staff staff = new Staff();
            SpellsBook spellsBook = new SpellsBook();
            
            this.EquipItem(staff);
            this.EquipItem(spellsBook);
        }
    }
}