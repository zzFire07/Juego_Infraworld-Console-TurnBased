namespace RoleplayGame
{
    public class Bow : IItem
    {
        public Bow()
        {
            this.AttackValue = 20;
            this.DefenseValue = 0;
            this.IsMagic = false;
        }
    }
}