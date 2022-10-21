namespace RoleplayGame
{
    public class Dwarf : ICharacters
    {
        ICharacters dwarf;
        public Dwarf(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.AttackValue = 100;
            this.DefenseValue = 100;
            this.IsDead = false;
        }

        public string Name { get; set; }
        public int Health {get; set; }
        public int AttackValue  { get; set; }
        public int DefenseValue { get; set; }

        public IItems EquippedItem { get; set; }

        public bool IsDead { get; set; }

        public void Cure(int cantidad)
        {
            this.Health += cantidad;
            if (this.Health > 100)
                this.Health = 100;
        }

        public void Damage(int cantidad)
        {
            this.Health -= cantidad;
        }

        public void MakeAttack(ICharacters character)
        {
            character.Damage(this.AttackValue);
        }

        private void UseMagic()
        {
            ///
            /// 
            ///
        }
    }
}