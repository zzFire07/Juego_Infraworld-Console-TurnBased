namespace RoleplayGame
{
    public class Helmet : IItems
    {
        public Helmet()
        {
            this.attackValue = 0;
            this.defenseValue = 20;
            this.isMagic = false;
        }

        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public bool isMagic { get; set; }
    }
}