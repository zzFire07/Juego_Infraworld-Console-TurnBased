using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell();
            Wizard gandalf = new Wizard("Gandalf");
            gandalf.EquipItem(book);

            Dwarf gimli = new Dwarf("Gimli");
            Shield escudo = new Shield();
            gimli.EquipItem(escudo);


            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gimli has ⛨ {gimli.DefenseValue} Defense");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"{gandalf.AttackValue}");
            Sword espada = new Sword();
            gandalf.EquipItem(espada);
            Console.WriteLine($"{gandalf.AttackValue}");
            Console.WriteLine($"{gandalf.Name} tiene equipado {gandalf.items}");
            Console.WriteLine($"{gandalf.Name} tiene equipado {gandalf.magicItems}");


            /* TEST :)
            Console.WriteLine($"{gandalf.AttackValue}");
            Sword espada = new Sword();
            gandalf.EquipItem(espada);
            Console.WriteLine($"{gandalf.AttackValue}");
            Console.WriteLine($"{gandalf.Name} tiene equipado {gandalf.items}");
            Console.WriteLine($"{gandalf.Name} tiene equipado {gandalf.magicItems}");
            */
        }
    }
}