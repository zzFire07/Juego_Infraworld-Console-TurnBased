namespace RoleplayGame
{
    public interface IHeroes
    {
        public int VictoryPoints { get; set; }
        public void AddVictoryPoints(int amount);
    }
}