namespace RoleplayGame
{
    public class Armor : IItems
    {
        public Armor()
        {
            this.attackValue = 0;
            this.defenseValue = 25;
            this.isMagic = false;
        }
        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public bool isMagic { get; set; }
    }

} 
