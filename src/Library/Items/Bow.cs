namespace RoleplayGame
{
    public class Bow : IItems
    {
        public Bow()
        {
            this.attackValue = 20;
            this.defenseValue = 0;
            this.isMagic = false;
        }

        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public bool isMagic { get; set; }
    }
}