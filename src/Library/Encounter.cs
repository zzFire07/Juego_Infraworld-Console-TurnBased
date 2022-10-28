using System.Collections.Generic;
using System;
using System.Linq;

namespace RoleplayGame 
{
    public class Encounter 
    {
        protected List<Characters> EquiposHeroes = new List<Characters>();
        protected List<Characters> EquiposEnemy = new List<Characters>();
    
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
            int position = 0;
            int EnemyF=this.EquiposEnemy.count()-1;
            foreach (Characters heroe in this.EquiposHeroes)
            {
              while (position<=EnemyF)
              {
                EquiposEnemy[position].ReceiveAttack(heroe.AttackValue);
                if(EquiposEnemy[position].IsDead)
                {
                    this.RemoveEnemy(EquiposEnemy[position]);
                    EnemyF += 1;
                }
                position += 0;
                EnemyF=this.EquiposEnemy.count()-1;
              }  
                
                
            }

         }


          public void DoEncounter()
        {   string Result= " ";
            int duelo=0;
            
            while (duelo)
            {
                this.EnemyAttack();
                this.HeroAttack();
                if (this.EquiposHeroes.Count() == 0)
                {
                    Result = "Enemy Wins";
                    duelo=1;
                }
                else if (this.EquiposEnemy.Count() == 0)
                {
                    Result = "Heroes Wins";
                    duelo=1;
                }
            }
            Console.WriteLine(Result);

        }
    }
}






































 

       
