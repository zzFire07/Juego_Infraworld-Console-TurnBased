namespace RoleplayGame
{
    public abstract class Characters
    {
        public abstract string Name { get; set; }
        public abstract int Health { get; set; }
        public abstract int AttackValue { get;}
        public abstract int DefenseValue { get;}
        public abstract bool IsDead { get;}

        public abstract void ReceiveAttack(int power);
        public abstract void Cure();
    }
}