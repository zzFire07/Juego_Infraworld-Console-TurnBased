namespace RoleplayGame
{
    public class Staff : IAttackMagic, IDefenseItem
    {
        public int AttackValue 
        {
            get
            {
                return 20;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 20;
            }
        }
    }
}