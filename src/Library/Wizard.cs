using System.Collections.Generic;

namespace RoleplayGame
{
    public class Wizard : IMagic, ICharacter
    {
        public string Name { get; }

        public Wizard(string name)
        {
            this.Name = name;
            this.IsDead = false;
        }

        private int Health = 100;

        public int AttackValue = 20;

        public int DefenseValue = 20;

        public Items EquippedItem { get; set; }

        public bool IsDead { get; set; }

        public void Cure(int cantidad)
        {
            this.Health += cantidad;
            if (this.Health > 100)
                this.Health = 100;
        }

        public void MakeAttack(ICharacter character)
        {
            character.ModifyHealth(- this.AttackValue);
        }

        private void UseMagic()
        {
            ///
            /// 
            ///
        }
    }
}