namespace RoleplayGame
{
    public class Knight : Characters
    {
        public int health{ get; set; } = 100;
        public Knight(string name)
        {
            this.Name = name;
        }

        public override string Name { get; set; }
        
        public Sword Sword { get; set; }

        public Armor Armor  { get; set; }
        
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
                return Sword.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return Shield.DefenseValue + Armor.DefenseValue;
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
