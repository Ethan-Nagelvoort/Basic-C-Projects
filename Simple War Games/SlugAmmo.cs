using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// SlugAmmo is a type of Weapon. 
    /// Has low bonus to attack.
    /// Percise but moderate damage.
    /// </summary>
    public class SlugAmmo : Weapon
    {
        /// <summary>
        /// SlugAmmo Constructor. Takes no arguments.
        /// Sets default values.
        /// </summary>
        public SlugAmmo()
        {
            this.name = "Slug";//name of weapon
            this.attackMod = 1;//attack modification
            damage.min = 5;//minimum damage this weapon can do
            damage.max = 6;//maximum damage this weapon can do
        }
    }
}

