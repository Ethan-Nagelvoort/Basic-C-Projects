using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// ExplodeAmmo is a type of Weapon. 
    /// Has no bonus to attack.
    /// Inpercise (wide range) but high damage.
    /// </summary>
    public class ExplodeAmmo : Weapon
    {
        /// <summary>
        /// ExplodeAmmo Constructor. Takes no arguments.
        /// Sets default values.
        /// </summary>
        public ExplodeAmmo()
        {
            this.name = "Explosive";//name of weapon
            this.attackMod = 0;//attack modification
            damage.min = 6;//minimum damage this weapon can do
            damage.max = 8;//maximum damage this weapon can do
        }
    }
}