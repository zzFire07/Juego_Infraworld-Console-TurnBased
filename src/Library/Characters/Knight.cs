 namespace RoleplayGame
{
    public class Knight : Characters, IHeroes
    {
        public Knight(string name) : base(name)
        {
            Armor armor = new Armor();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();
            Sword sword = new Sword();

            this.EquipItem(armor);
            this.EquipItem(helmet);
            this.EquipItem(shield);
            this.EquipItem(sword);
        }
    }
}