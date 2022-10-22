namespace RoleplayGame
{
    public class Staff : IMagicItem
    {
        public int AttackValue 
        {
            get
            {
                return 100;
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