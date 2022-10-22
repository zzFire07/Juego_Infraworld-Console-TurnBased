namespace RoleplayGame
{
    public class Dwarf : Characters
    {
        public int health{ get; set; } = 100;
        public Dwarf(string name)
        {
            this.Name = name;
        }

        public override string Name { get; set; }
        
        public Axe Axe { get; set; }

        public Helmet Helmet { get; set; }
        
        public Shield Shield {get;set; }
        
        
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
                return Axe.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return Shield.DefenseValue + Helmet.DefenseValue;
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
