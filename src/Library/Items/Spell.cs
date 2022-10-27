namespace RoleplayGame
{
    public class Spell : ISpell
    {
        public int AttackValue
        {
            get
            {
                return 25;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 0;
            }
        }
    }
}