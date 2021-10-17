using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// PirecingAmmo is a type of Weapon. 
    /// Has moderate bonus to attack.
    /// Average damage spread with low damage.
    /// </summary>
    public class PiercingAmmo : Weapon
    {
        Random random = new Random();
        /// <summary>
        /// PiercingAmmo Constructor. Takes no arguments.
        /// Sets default values.
        /// </summary>
        public PiercingAmmo()
        {
            this.name = "Piercing";//name of weapon
            this.attackMod = 3;//attack modification
            damage.min = 4;//minimum damage this weapon can do
            damage.max = 6;//maximum damage this weapon can do
        }
    }
}