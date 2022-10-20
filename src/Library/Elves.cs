namespace RoleplayGame
{
    public class Elves : ICharacters
    {
        public Elves (string name)
        {
            this.Name = name;
            this.Health = 100;
            this.AttackValue = 100;
            this.DefenseValue = 100;
            this.IsDead = false;
        }
    }
}