namespace RoleplayGame
{
    public class Spell : IItems
    {
        public Spell()
        {
            this.attackValue = 70;
            this.defenseValue = 70;
            this.isMagic = true;
        }

        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public bool isMagic { get; set; }
    }
}