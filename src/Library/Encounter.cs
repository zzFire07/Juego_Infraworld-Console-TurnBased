using System.Collections.Generic;
using System;
using System.Linq;

namespace RoleplayGame 
{
    public class Encounter 
    {
        public List<Characters> EquiposHeroes = new List<Characters>();
        public List<Characters> EquiposEnemy = new List<Characters>();
    
        public void AddHeroes(Characters heroes)
        {
            EquiposHeroes.Add(heroes);
        }
        public void AddEnemies(Characters enemies)
        {
            EquiposEnemy.Add(enemies);
        }
        
        public void RemoveHeroe(Characters heroe)
        {
            EquiposHeroes.Remove(heroe);
        }
    
        public void RemoveEnemy(Characters enemy)
        {
            EquiposEnemy.Remove(enemy);
        }

        public void Equipos()
        {
            Console.WriteLine(" Hereoes are :");
            foreach (Characters hero in this.EquiposHeroes)
            {
                Console.WriteLine(hero.Name);
            }
        
            Console.WriteLine(" !VS¡");

            Console.WriteLine(" Enemies are :");
            foreach (Characters enemy in this.EquiposEnemy)
            {
                Console.WriteLine(enemy.Name);
            }
        }

        public void EnemyAttack()
        {
            int cantidadHeroes = EquiposHeroes.Count();
            int position = 0;

            foreach (Characters enemy in this.EquiposEnemy)
            {
                EquiposHeroes[position].ReceiveAttack(enemy.AttackValue);

                if(EquiposHeroes[position].IsDead)
                {
                    this.RemoveHeroe(EquiposHeroes[position]);
                    cantidadHeroes -= 1;
                }

                position += 1;
                
                if (position >= cantidadHeroes)
                    position = 0;
            }
        }



        public void HeroAttack()
        {
            foreach (Characters heroe in this.EquiposHeroes)
            {
                int pos = 0;
                int EnemiesAmount = EquiposEnemy.Count();
                if (EquiposEnemy != null)
                    while (pos < EnemiesAmount)
                    {
                        EquiposEnemy[pos].ReceiveAttack(heroe.AttackValue);
                        if(EquiposEnemy[pos].IsDead)
                            {
                                heroe.AddVictoryPoints(EquiposEnemy[pos].VictoryPoints);
                                this.RemoveEnemy(EquiposEnemy[pos]);
                                pos -= 1;
                                EnemiesAmount -= 1;

                                if (heroe.VictoryPoints >= 5)
                                {
                                    heroe.Cure();
                                    heroe.VictoryPoints = 0;
                                }
                            }
                        pos += 1;
                    }  
            }
         }


        public void DoEncounter()
        { 
            string Result = "";
            bool duelo = true;
            
            while (duelo)
            {
                this.EnemyAttack();
                this.HeroAttack();
                if (this.EquiposHeroes.Count() == 0)
                {
                    Result = "Enemy Wins!";
                    duelo = false;
                }
                else if (this.EquiposEnemy.Count() == 0)
                {
                    Result = "Heroes Wins!";
                    duelo = false;
                }
            }
            Console.WriteLine(Result);
        }
    }
}






































 

       
