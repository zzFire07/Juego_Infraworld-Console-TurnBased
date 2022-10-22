namespace RoleplayGame
{
    public class Wizard : Characters
    {
        public int health{ get; set; } = 100;
        public Wizard(string name)
        {
            this.Name = name;
        }

        public override string Name { get; set; }
        
        public Staff Staff { get; set; }

        public SpellsBook SpellsBook { get; set; }
        
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
                return Staff.AttackValue+ SpellsBook.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue+Staff.DefenseValue;
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
