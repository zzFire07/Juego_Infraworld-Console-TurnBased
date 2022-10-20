namespace RoleplayGame
{
    public interface ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public bool IsDead { get; set; }
        public void MakeAttack(ICharacter character);
        public void Cure();
        public void EquipItem(IItem item);
        public void RemoveItem(IItem item);
    }
}