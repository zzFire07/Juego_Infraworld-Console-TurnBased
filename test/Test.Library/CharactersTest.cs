using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class CharactersTest
    {
        [Test]
        public void TestAttack()
        {
            Dwarf dwarf1 = new Dwarf("Pedro");

            Wizard wizard1 = new Wizard("Juan");
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

        [Test]
        public void TestCure()
        {
            Archer archer2 = new Archer("Pedro");
            Knight knight2 = new Knight("Juan");

            archer2.ReceiveAttack(knight2.AttackValue);
            archer2.Cure();

            int expected2 = 100;
            int result2 = archer2.Health;
            Assert.That(result2, Is.EqualTo(expected2));
        }

        [Test]
        public void TestName()
        {
            Archer archer3 = new Archer("Pedro");
            
            const string expected3 = "Pedro";
            string result3 = archer3.Name;
            Assert.That(result3, Is.EqualTo(expected3));
        }

        [Test]
         public void TestDead()
        {
            Dwarf dwarf4 = new Dwarf("Pedro");
            
            Wizard wizard4 = new Wizard("Juan");
            wizard4.spellsBook.AddSpell();

            while(dwarf4.Health > 0)
            {
                dwarf4.ReceiveAttack(wizard4.AttackValue);
            }
            

            bool expected4 = true;
            bool result4 = dwarf4.IsDead;
            Assert.That(result4, Is.EqualTo(expected4));
        }
    }
}
