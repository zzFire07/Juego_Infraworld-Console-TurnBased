namespace RoleplayGame
{
    public class EnemyRatMan : Characters, IEnemies
    {
        public EnemyRatMan(string name) : base(name)
        {
            this.VictoryPoints = 25;

            Sword sword1 = new Sword();
            Sword sword2 = new Sword();
            
            this.EquipItem(sword1);
            this.EquipItem(sword2);
        }
    }
}