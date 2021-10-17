using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWarGame
{
    /// <summary>
    /// Abstract base class for all weapons in the game.
    /// </summary>
    public abstract class Weapon : GameObject
    {
        protected int AttackMod;//attackMod helps determin hit value in the defend function
        public Damage damage;

        public struct Damage//damage struck contains a max and a min, damage value will be between them
        {
            public int min, max;
        }

        public int attackMod//definition of attackMod since its a protected variable, helps us aquire it in other classes
        {
            get//accessor function
            {
                return AttackMod;
            }
            set//mutator function
            {
                AttackMod = value;
            }
        }
    }
}