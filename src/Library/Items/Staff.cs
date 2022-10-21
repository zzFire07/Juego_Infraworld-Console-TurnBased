namespace RoleplayGame
{
    public class Staff : IItems
    {
        public Staff()
        {
            this.attackValue = 100;
            this.defenseValue = 100;
            this.isMagic = true;
        }

        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public bool isMagic { get; set; }
    }
}