namespace Library
{
    public class Knight: Character
    {
        public Knight(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.AttackValue = 20;
            this.DefenseValue = 20;
            this.IsDead = false;
        }
    }
}