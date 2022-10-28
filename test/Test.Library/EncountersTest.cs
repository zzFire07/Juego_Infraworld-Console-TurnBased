using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class EncountersTest
    {
        [Test]
        public void TestEnemies()
        {
            Wizard mago1 = new Wizard("Mago 1");
            Knight caballero1 = new Knight("Caballero 1");

            EnemyWizard magoEnemigo1 = new EnemyWizard("Mago Enemigo");
            EnemyRatMan rataEnemiga1 = new EnemyRatMan("Rata Enemiga");


            Encounter encounter = new Encounter();

            encounter.AddHeroes(mago1);
            encounter.AddHeroes(caballero1);

            encounter.AddEnemies(magoEnemigo1);
            encounter.AddEnemies(rataEnemiga1);

            encounter.Equipos();
            encounter.DoEncounter();

            List<Characters> expectedEnemiesList = new List<Characters>();
            List<Characters> resultEnemiesList = encounter.EnemyTeam;
            
            Assert.That(expectedEnemiesList, Is.EqualTo(resultEnemiesList)); 
        }

        [Test]
        public void TestHeroes()
        {
            Wizard mago2 = new Wizard("Mago 2");
            Knight caballero2 = new Knight("Caballero 2");

            EnemyWizard magoEnemigo2 = new EnemyWizard("Mago Enemigo2");
            EnemyRatMan rataEnemiga2 = new EnemyRatMan("Rata Enemiga2");


            Encounter encounter2 = new Encounter();

            encounter2.AddHeroes(mago2);
            encounter2.AddHeroes(caballero2);

            encounter2.AddEnemies(magoEnemigo2);
            encounter2.AddEnemies(rataEnemiga2);

            encounter2.DoEncounter();

            //Se inicializa y no se agrega nada porque se espera que result esté vacía
            List<Characters> expectedEnemiesList = new List<Characters>();
            List<Characters> resultEnemiesList = encounter2.EnemyTeam;
            
            Assert.That(expectedEnemiesList, Is.EqualTo(resultEnemiesList));            
        }
    }
}