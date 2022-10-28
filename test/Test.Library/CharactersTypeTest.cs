/*using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class CharactersTypeTest
    {
        [Test]
        public void TestHeroes()
        {
            Wizard wizard1 = new Wizard("Juan");
            E

            wizard1.spellsBook.AddSpell();

            //Esto comprueba que cada Wizard tenga un spellsBook individual,
            //siendo que si apuntaran a un mismo objeto, el daño se sumaría.
            Wizard wizard1_2 = new Wizard("Juan2");
            wizard1_2.spellsBook.AddSpell();

            wizard1.ReceiveAttack(dwarf1.AttackValue);

            int expected1 = 100 - 25;
            int result1 = wizard1.Health;
            Assert.That(result1, Is.EqualTo(expected1));
        }
    }
}*/
