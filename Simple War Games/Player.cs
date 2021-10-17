using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// The Player class.  High Health and Armor. Uses various kinds of Ammo selected by the player.
    /// </summary>
    public class Player : Entity
    {
        /// <summary>
        /// Player Constructor. Takes no arguments.
        /// Initalizies an Player to default values.
        /// </summary>
        public Player()
        {
            this.maxHealth = 60;
            this.health = maxHealth;
            this.armor = 7;
            this.Name = "Player";
            this.weapon = null;//null cause player decides what weapon to use
        }

        /// <summary>
        /// Allows the player to select which weapon they want to use.
        /// </summary>
        /// <param name="type">The weapon they would like to use. Check the weaponType enum for possible options.</param>
        public void SelectWeapon(weaponType type)
        {
            switch (type)//playe selects any of these two weapons, they are described in weapons folder
            {
                case weaponType.explosive:
                    this.weapon = new ExplodeAmmo();
                    break;
                case weaponType.piercing:
                    this.weapon = new PiercingAmmo();
                    break;
            }
        }

        /// <summary>
        /// Heals the player to maximum health.
        /// </summary>
        public void Heal()//Mechanic sets tank health back to max each round
        {
            this.health = this.maxHealth;
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
