namespace RoleplayGame
{
    public class Archer : Characters, IHeroes
    {
         public Archer(string name) : base(name)
        {
            Armor armor = new Armor();
            Bow bow = new Bow();

            this.EquipItem(armor);
            this.EquipItem(bow);
        } 
    }
}
