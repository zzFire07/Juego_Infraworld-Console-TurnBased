using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class CharactersTest
    {
        [Test]
        public void TestAttack()
        {
            Characters dwarf1 = new Dwarf("Pedro");
            Characters wizard1 = new Wizard("Juan");

            wizard1.ReceiveAttack(dwarf1.AttackValue());

            int expected1 = 100 - 25;
            int result1 = wizard1.Health;
            Assert.That(result1, Is.EqualTo(expected1));
        }

        [Test]
        public void TestCure()
        {
            Characters archer1 = new Archer("Pedro");
            Characters knight1 = new Knight("Juan");

            archer1.ReceiveAttack(knight1.AttackValue);
            archer1.Cure();

            int expected2 = 100;
            int result2 = archer1.Health;
            Assert.That(result2, Is.EqualTo(expected2));
        }

        [Test]
        public void TestName()
        {
            Characters archer2 = new Archer("Pedro");
            
            const string expected3 = "Pedro";
            string result3 = archer2.Name;
            Assert.That(result3, Is.EqualTo(expected3));
        }

        [Test]
        public void TestDead()
        {
            Characters dwarf2 = new Dwarf("Pedro");
            Characters wizard2 = new Wizard("Juan");

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