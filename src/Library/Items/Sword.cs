namespace RoleplayGame
{
    public class Sword : IItems
    {
        public Sword()
        {
            this.attackValue = 40;
            this.defenseValue = 0;
            this.isMagic = false;
        }

        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public bool isMagic { get; set; }
    }
}