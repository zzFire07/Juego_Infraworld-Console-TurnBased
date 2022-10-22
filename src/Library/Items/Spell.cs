namespace RoleplayGame
{
    public class Spell : IMagicItem
    {
        public int AttackValue
        {
            get
            {
                return 70;
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