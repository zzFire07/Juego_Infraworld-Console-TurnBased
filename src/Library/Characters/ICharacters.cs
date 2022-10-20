namespace RoleplayGame
{
    public interface ICharacters
    {
        protected string Name { get; set; }
        protected int Health { get; set; }
        protected int AttackValue { get; set; }
        protected int DefenseValue { get; set; }
        protected bool IsDead { get; set; }
        protected void MakeAttack(ICharacters character);
        protected void Cure(int cantidad);
        public void Damage(int cantidad);
        protected void EquipItem(IItems item);
        protected void RemoveItem(IItems item);
    }
}