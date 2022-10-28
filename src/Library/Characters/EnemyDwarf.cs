namespace RoleplayGame
{
    public class EnemyDwarf : Characters,IEnemies
    {
        
        public EnemyDwarf(string name) : base (name)
        {
            this.VictoryPoints = 25;
            
            Helmet helmet = new Helmet();
            Axe axe = new Axe();
            
            this.EquipItem(helmet);
            this.EquipItem(axe);

            
        }    
    }
}