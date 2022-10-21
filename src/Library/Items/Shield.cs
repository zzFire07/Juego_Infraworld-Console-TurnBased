namespace RoleplayGame
{
    public class Shield : IItems
    {
        public Shield()
        {
            this.attackValue = 0;
            this.defenseValue = 14;
            this.isMagic = false;
        }
        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public bool isMagic { get; set; }
    }
}