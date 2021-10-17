using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// MissleAmmo is a type of Weapon. 
    /// Has high bonus to attack.
    /// Average damage spread with high damage.
    /// </summary>
    public class MissleAmmo : Weapon
    {
        /// <summary>
        /// MissleAmmo Constructor. Takes no arguments.
        /// Sets default values.
        /// </summary>
        public MissleAmmo()
        {
            this.name = "Missle";//Name of weapon
            this.attackMod = 4;//attack modification
            damage.min = 6;//minimum damage this weapon can do
            damage.max = 8;//maximum damage this weapon can do
        }
    }
}

