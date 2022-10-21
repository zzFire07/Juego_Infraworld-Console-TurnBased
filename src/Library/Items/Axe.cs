namespace RoleplayGame
{
    public class Axe: IItems
    {
        public Axe()
        {
            this.attackValue = 25;
            this.defenseValue = 0;
            this.isMagic = false;
        }
        public int attackValue { get; set; }
        public int defenseValue { get; set; }
        public bool isMagic { get; set; }
    }
    
    
}