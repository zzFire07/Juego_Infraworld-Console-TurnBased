using System.Collections.Generic;
using System;
using System.Linq;

namespace RoleplayGame 
{
    public class Encounter 
    {
        public List<Characters> HeroTeam = new List<Characters>();
        public List<Characters> EnemyTeam = new List<Characters>();
    
        public void AddHeroes(Characters heroes)
        {
            HeroTeam.Add(heroes);
        }
        public void AddEnemies(Characters enemies)
        {
            EnemyTeam.Add(enemies);
        }
        
        public void RemoveHeroe(Characters heroe)
        {
            HeroTeam.Remove(heroe);
        }
    
        public void RemoveEnemy(Characters enemy)
        {
            EnemyTeam.Remove(enemy);
        }

        public void Equipos()
        {
            Console.WriteLine(" Hereoes are :");
            foreach (Characters hero in this.HeroTeam)
            {
                Console.WriteLine(hero.Name);
            }
        
            Console.WriteLine(" !VS¡");

            Console.WriteLine(" Enemies are :");
            foreach (Characters enemy in this.EnemyTeam)
            {
                Console.WriteLine(enemy.Name);
            }
        }

        public void EnemyAttack()
        {
            int cantidadHeroes = HeroTeam.Count();
            int position = 0;

            foreach (Characters enemy in this.EnemyTeam)
            {
                HeroTeam[position].ReceiveAttack(enemy.AttackValue);

                if(HeroTeam[position].IsDead)
                {
                    this.RemoveHeroe(HeroTeam[position]);
                    cantidadHeroes -= 1;
                }

                position += 1;
                
                if (position >= cantidadHeroes)
                    position = 0;
            }
        }



        public void HeroAttack()
        {
            foreach (Characters heroe in this.HeroTeam)
            {
                int pos = 0;
                int EnemiesAmount = EnemyTeam.Count();
                if (EnemyTeam != null)
                    while (pos < EnemiesAmount)
                    {
                        EnemyTeam[pos].ReceiveAttack(heroe.AttackValue);
                        if(EnemyTeam[pos].IsDead)
                            {
                                heroe.AddVictoryPoints(EnemyTeam[pos].VictoryPoints);
                                this.RemoveEnemy(EnemyTeam[pos]);
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
                if (this.HeroTeam.Count() == 0)
                {
                    Result = "Enemy Wins!";
                    duelo = false;
                }
                else if (this.EnemyTeam.Count() == 0)
                {
                    Result = "Heroes Wins!";
                    duelo = false;
                }
            }
            Console.WriteLine(Result);
        }
    }
}

