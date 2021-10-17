using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// The EnemyTruck class.  Low Health and Armor. Uses Missle Ammo.
    /// </summary>
    public class EnemyTruck : Entity
    {
        /// <summary>
        /// EnemyTruck Constructor. Takes no arguments.
        /// Initalizies an EnemyTruck to default values.
        /// </summary>
        public EnemyTruck()
        {
            this.maxHealth = 20;
            this.health = maxHealth;
            this.armor = 4;
            this.Name = "Truck";
            weapon = new MissleAmmo();
        }

        public override void Attack(Entity target)//function is overrieded from abstract class in Entity
        {
            Random numGen = new Random();//random number to help determine hit value
            Console.WriteLine("The " + this.name + " is attacking with " + this.weapon.Name);
            target.Defend(numGen.Next(15) + weapon.attackMod,
                numGen.Next(weapon.damage.min, weapon.damage.max));//damage can be between min and max of weapon
        }

        public override void Defend(int hit, int damage)//function is overrieded from abstract class in Entity
        {
            if (hit > this.Armor)//If hit is over armor, damage is taken
            {
                Health -= damage;
                Console.WriteLine("The " + this.name + " was hit for " + damage);
            }
            else
            {
                Console.WriteLine("The " + this.name + " was missed");
            }
        }
    }
}
