namespace RoleplayGame
{
    public class Archer : Characters
    {
        public int health{ get; set; } = 100;
        public Archer(string name)
        {
            this.Name = name;
        }

        public override string Name { get; set; }
        
        Bow Bow = new Bow();

        Helmet Helmet = new Helmet();

        public override bool IsDead
        {
            get
            {
                return this.Health <= 0;
            }
        }

        public override int AttackValue
        {
            get
            {
                return Bow.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return Helmet.DefenseValue;
            }
        }

        public override int Health
        {
            get
            {
                return this.health;
            }
             set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public override void Cure()
        {
            this.Health = 100;
        }
    }
}
