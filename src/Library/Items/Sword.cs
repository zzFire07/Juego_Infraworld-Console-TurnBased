namespace RoleplayGame
{
    public class Sword : IItem
    {
        public Sword()
        {
            this.AttackValue = 40;
            this.DefenseValue = 0;
            this.IsMagic = false;
        }
    }
}