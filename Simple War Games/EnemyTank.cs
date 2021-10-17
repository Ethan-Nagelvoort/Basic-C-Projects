using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// The EnemyTank class.  High health and Armor. Uses Slug Ammo.
    /// </summary>
    public class EnemyTank : Entity
    {
        /// <summary>
        /// EnemyTank Constructor. Takes no arguments.
        /// Initalizies an EnemyTank to default values.
        /// </summary>
        public EnemyTank()
        {
            this.maxHealth = 60;
            this.health = maxHealth;
            this.armor = 6;
            this.Name = "Tank";
            weapon = new SlugAmmo();
        }

        public override void Attack(Entity target)//function is overrieded from abstract class in Entity
        {
            Random numGen = new Random();//random number to help determine hit value
            Console.WriteLine("The " + this.name + " is attacking with " + this.weapon.Name);
            target.Defend(numGen.Next(10) + weapon.attackMod, 
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