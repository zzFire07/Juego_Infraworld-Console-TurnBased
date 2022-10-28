using System.Collections.Generic;
using System;
using system.Linq;

namespace RoleplayGame 

{
    partial class  Encounter1
    {
    public class Encounter 
    {
        protected list<IHeroes> EquiposHeroes = new list<IHeroes>();
        protected list<IEnemies> EquiposEnemigos = new list<IEnemies>();
    
        public void AddHeroes(IHeroes heroes)
        {
            EquiposHeroes.Add(heroes);
        }
        public void AddEnemies(IEnemies enemies)
        {
            EquiposEnemigos.Add(enemies);
        }
        
        public void RemoveHeroe(Heroe heroe)
        {
            EquiposHeroes.Remove(heroe);
        }
    
        public void RemoveEnemy(Enemy enemy)
        {
            EquiposEnemigos.Remove(enemy);
        }

        public void Equipos()
        {
            Console.WriteLine(" Hereoes are :");
            foreach (Hereo h in this.EquiposHeroes);
            {
                Console.WriteLine(h.Name);
            }
        
            Console.WriteLine(" VS");

            Console.WriteLine(" Enemies are :");
            foreach (Enemy e in this.EquiposEnemigos);
            {
                Console.WriteLine(e.Name);
            }
        }
        }
        partial class  Encounter2
        {
        public void EnemyAttack()
        
        {
          int totalAttack = 0;  
            foreach (Enemy e in this.EquiposEnemigos)
            {
                EquipoHeroes.ForEach(h => h.ReceiveAttack(e.AttackValue));
                if(h.Health == 0)
                {
                    this.RemoveHeroe(h);
                }
                this.RemoveHeroe(h);
            }
            totalAttack++;
            if(totalAttack>=this.EquiposHeroes.Count)
            {
                totalAttack = 0;
            }
        }

        public void HeroAttack()
        {
         int totalAttack=0;  
        }





        partial class  Encounter3
        {


        }

        }


    









    
    
    }




}
