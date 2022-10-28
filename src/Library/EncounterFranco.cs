using System.Collections.Generic;
using System;
using System.Linq;

namespace RoleplayGame 
{
    public class Encounter 
    {
        protected List<Characters> EquiposHeroes = new List<Characters>();
        protected List<Characters> EquiposEnemigos = new List<Characters>();
    
        public void AddHeroes(Characters heroes)
        {
            EquiposHeroes.Add(heroes);
        }
        public void AddEnemies(Characters enemies)
        {
            EquiposEnemigos.Add(enemies);
        }
        
        public void RemoveHeroe(Characters heroe)
        {
            EquiposHeroes.Remove(heroe);
        }
    
        public void RemoveEnemy(Characters enemy)
        {
            EquiposEnemigos.Remove(enemy);
        }

        public void Equipos()
        {
            Console.WriteLine(" Hereoes are :");
            foreach (Characters hero in this.EquiposHeroes)
            {
                Console.WriteLine(hero.Name);
            }
        
            Console.WriteLine(" VS");

            Console.WriteLine(" Enemies are :");
            foreach (Characters enemy in this.EquiposEnemigos)
            {
                Console.WriteLine(enemy.Name);
            }
        }

        public void EnemyAttack()
        {
            int cantidadHeroes = EquiposHeroes.Count();
            int position = 0;

            foreach (Characters enemigo in this.EquiposEnemigos)
            {
                EquiposHeroes[position].ReceiveAttack(enemigo.AttackValue);

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
         int totalAttack=0;  
        }

    }
}