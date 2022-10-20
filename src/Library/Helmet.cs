namespace RoleplayGame
{
    public class Helmet : IItem
    {
        public Helmet()
        {
            this.AttackValue = 0;
            this.DefenseValue = 20;
            this.IsMagic = false;
        }
    }
}