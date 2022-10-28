 namespace RoleplayGame
{
    public class Dwarf : Characters, IHeroes
    {
        public Dwarf(string name) : base(name)
        {
            Helmet helmet = new Helmet();
            Axe axe = new Axe();

            this.EquipItem(helmet);
            this.EquipItem(axe);
        }
    }
}