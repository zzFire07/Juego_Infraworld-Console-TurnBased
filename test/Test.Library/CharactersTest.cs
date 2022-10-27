using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class CharactersTest
    {
        [Test]
        public void TestAttack()
        {
            Axe axe = new Axe();
            SpellsBook book = new SpellsBook();
            book.AddSpell();

            Dwarf dwarf1 = new Dwarf("Pedro");
            Wizard wizard1 = new Wizard("Juan");

            dwarf1.EquipItem(axe);
            wizard1.EquipItem(book);


            wizard1.ReceiveAttack(dwarf1.AttackValue);

            int expected1 = 100 - 25;
            int result1 = wizard1.Health;
            Assert.That(result1, Is.EqualTo(expected1));
        }

        [Test]
        public void TestCure()
        {
            Sword sword1 = new Sword();
            Bow bow1 = new Bow();
            Helmet helmet1 = new Helmet();
            Helmet helmet2 = new Helmet();

            Archer archer1 = new Archer("Pedro");
            Knight knight1 = new Knight("Juan");

            archer1.EquipItem(sword1);
            knight1.EquipItem(bow1);
            knight1.EquipItem(helmet1);
            archer1.EquipItem(helmet2);


            archer1.ReceiveAttack(knight1.AttackValue);
            archer1.Cure();

            int expected2 = 100;
            int result2 = archer1.Health;
            Assert.That(result2, Is.EqualTo(expected2));
        }

        [Test]
        public void TestName()
        {
            Archer archer2 = new Archer("Pedro");
            
            const string expected3 = "Pedro";
            string result3 = archer2.Name;
            Assert.That(result3, Is.EqualTo(expected3));
        }

        [Test]
         public void TestDead()
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell();
            Sword sword2 = new Sword();
            Helmet helmet3 = new Helmet();

            Dwarf dwarf2 = new Dwarf("Pedro");
            Wizard wizard2 = new Wizard("Juan");

            wizard2.EquipItem(book);
            dwarf2.EquipItem(helmet3);


            while(dwarf2.Health > 0)
            {
                dwarf2.ReceiveAttack(wizard2.AttackValue);
            }
            

            bool expected4 = true;
            bool result4 = dwarf2.IsDead;
            Assert.That(result4, Is.EqualTo(expected4));
        }
    }
}
