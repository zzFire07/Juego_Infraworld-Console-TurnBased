namespace RoleplayGame
{
    public interface ICharacters
    {
        public string Name { get; set; }
        public int health { get; set; }
        public int AttackValue { get;}
        public int DefenseValue { get;}
        public bool IsDead { get;}
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.health = 100;
        }
    }
}