namespace Library
{
    public class Elves : Character
    {
        public Elves(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.AttackValue = 20;
            this.DefenseValue = 20;
            this.IsDead = false;
        }
    }
}